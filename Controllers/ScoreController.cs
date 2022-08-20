using ADHD.Dto;
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
        private IMapper mapper;
        public ScoreController(IScoreRepository scoreRepository, IMapper mapper)
        {
            this.scoreRepository = scoreRepository;
            this.mapper = mapper;
        }

        public IActionResult AddSymptomScore(List<AddSymptomScoreDto> scoreDto)
        {
            var scoreModel = new List<DisorderResult>();
            scoreDto.ForEach(x => scoreModel.Add(mapper.Map<DisorderResult>(x)));
            scoreRepository.AddScore(scoreModel);
            return Ok(scoreModel);
        }
    }
}
