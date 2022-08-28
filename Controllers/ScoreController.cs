using ADHD.Dto;
using ADHD.Middleware;
using ADHD.Middleware.disorder;
using ADHD.Middleware.score;
using ADHD.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace ADHD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScoreController : Controller
    {
        private IScoreRepository scoreRepository;
        private ISymptomQuestionRepository symptomQuestionRepository;
        private IStudentRepsitory studentRepository;
        private IOptionRepository optionRepository;
        private IMapper mapper;
        public ScoreController(
            IScoreRepository scoreRepository,
            IOptionRepository optionRepository,
            IStudentRepsitory studentRepository,
            IMapper mapper,
            ISymptomQuestionRepository symptomQuestionRepository)
        {
            this.scoreRepository = scoreRepository;
            this.mapper = mapper;
            this.symptomQuestionRepository = symptomQuestionRepository;
            this.optionRepository = optionRepository;
            this.studentRepository = studentRepository;
        }

        [HttpPost("disorder/score")]
        public async Task<IActionResult> AddSymptomScore(List<AddSymptomScoreDto> scoreDto)
        {
            if (!AssesstBefore(scoreDto))
            {
                int totalScore = 0;
                var scoreModel = new List<DisorderResult>();
                scoreDto.ForEach(x => scoreModel.Add(mapper.Map<DisorderResult>(x)));
                var score = await scoreRepository.AddScore(scoreModel);
                int symptomQuestionId = score[0].SymptomQuestionId;
                score.ForEach(x => { var option = optionRepository.GetOptionById(x.OptionId); totalScore += option.Marks; });

                var symptom = await symptomQuestionRepository.FindSymptomQuestion(symptomQuestionId);
                SymptomScore disorderScore = new()
                {
                    Student = await studentRepository.GetStudentById(Guid.Parse(score[0].StudentId)),
                    StudentId = score[0].StudentId,
                    DisorderId = symptom.DisorderId,
                    SymptomId = symptom.Id,
                    Score = totalScore,
                    DiagnosedLevel = scoring(symptom.DisorderId, totalScore),
                    LastUpdated = DateTime.Now,
                };

                var symptomScore = await scoreRepository.AddDisorderScore(disorderScore);
                return Ok(disorderScore);
            }
            return BadRequest("Already take a test within 2 months");
        }

        private bool AssesstBefore(List<AddSymptomScoreDto> scoreDto)
        {
            return false;
        }

        private string scoring(int disorderId , int totalScore)
        {
            string level;
            if(disorderId == 1)
            {
                level = totalScore*2 > 26 ? "Severe" : (totalScore*2 <= 14 ? "Normal" : "Moderate");
            }
            else if(disorderId == 2)
            {
                level = totalScore*2 > 15 ? "Severe" : (totalScore*2 <= 7 ? "Normal" : "Moderate");
            }
            else if(disorderId == 3)
            {
                level = totalScore*2 > 21 ? "Severe" : (totalScore*2 <= 9 ? "Normal" : "Moderate");
            }
            else
            {
                level = totalScore > 7 ? "Severe" : (totalScore <= 3 ? "Normal" : "Moderate");
            }
            return level;
        }
    }
}
