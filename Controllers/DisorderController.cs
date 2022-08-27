using ADHD.Dto.disorder;
using ADHD.Middleware.disorder;
using ADHD.Models.Disorder;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace ADHD.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DisorderController : Controller
    {   
        IDisorderRepository _disorderRepository;
        ISymptomRepository _symptomRepository;
        ISymptomQuestionRepository _symptomQuestionRepository;
        IQuestionOptionRepository _questionOptionRepository;
        IQuestionRepository _questionRepository;
        IOptionRepository _optionRepository;
        IMapper _mapper;
        public DisorderController(IDisorderRepository disorderRepository,
            ISymptomRepository symptomRepository,
            ISymptomQuestionRepository symptomQuestionRepository,
            IQuestionOptionRepository questionOptionRepository,
            IQuestionRepository questionRepository,
            IOptionRepository optionRepository,
            IMapper mapper
        )
        {
            this._disorderRepository = disorderRepository;
            this._symptomRepository = symptomRepository;
            this._symptomQuestionRepository = symptomQuestionRepository;
            this._questionOptionRepository = questionOptionRepository;
            this._questionRepository = questionRepository;
            this._optionRepository = optionRepository;
            this._mapper = mapper;
        }


        [HttpPost("disorder")]
        public async Task<IActionResult> AddDisorder([FromBody] DisorderDto disorderDto)
        {
            var disorderModel = _mapper.Map<Disorder>(disorderDto);
            var disorder = await _disorderRepository.AddDisorder(disorderModel);
            return Ok(disorderDto);

        }

        [HttpPost("symptom")]
        public async Task<IActionResult> AddSymptom([FromBody] SymptomDto symptomDto)
        {
            var symptomModel = _mapper.Map<Symptom>(symptomDto);
            var symptom = await _symptomRepository.AddSymptom(symptomModel);
            return Ok(symptomDto);
        }

        [HttpPost("question")]
        public async Task<IActionResult> AddQuestion([FromBody] QuestionDto questionDto)
        {
            var questionModel = _mapper.Map<Question>(questionDto);
            var question = await _questionRepository.AddQuestion(questionModel);
            return Ok(questionDto);
        }

        [HttpPost("option")]
        public async Task<IActionResult> AddOption([FromBody] OptionDto optionDto)
        {
            var optionModel = _mapper.Map<Option>(optionDto);
            var option = await _optionRepository.AddOption(optionModel);
            return Ok(optionDto);

        }

        [HttpPost("symptom/question")]
        public async Task<IActionResult> AddSymptomQuesyion([FromBody] SymptomQuestionDto symptomQuestionDto)
        {
               var symptomQuestionModel = _mapper.Map<SymptomQuestion>(symptomQuestionDto);
            var symptomQuestion = await _symptomQuestionRepository.AddSymptomQuestion(symptomQuestionModel);
            return Ok(symptomQuestionDto);
        }
        
        [HttpPost("question/option")]
        public async Task<IActionResult> AddQuestionOption([FromBody]QuestionOptionDto questionOptionDto)
        {
            var questionOptionModel = _mapper.Map<QuestionOption>(questionOptionDto);
            var questionOption =await _questionOptionRepository.AddQuestionOption(questionOptionModel);
            return Ok(questionOptionDto);

        }

        [HttpGet("disorder")]
        public async Task<IActionResult> GetDisorder()
        {
                var disorder = await _disorderRepository.GetDisorder();
            var disorderDto = new List<GetDisorderDto>();
            disorder.ForEach(x => disorderDto.Add(_mapper.Map<GetDisorderDto>(x)));
                return Ok(disorderDto);
        }

        [HttpGet("symptom/{disorderId}")]
        public async Task<IActionResult> Symptom(int disorderId)
        {
            var symptom = await _symptomRepository.GetSymptom(disorderId);
            var symptomDto = new List<GetSymptomDto>();
            symptom.ForEach(x => symptomDto.Add(_mapper.Map<GetSymptomDto>(x)));
            return Ok(symptomDto);
        }

        [HttpGet("symptom/question/{symptomId}")]
        public async Task<IActionResult> QuestionOption(int symptomId)
        {
            var questionOptions = new List<GetQuestionOptionsDto>();
            var symptomquestions = await _symptomQuestionRepository.GetSymptomQuestion(symptomId);
            foreach(var symptomQuestion in symptomquestions)
            {
                var questionDto = _mapper.Map<GetQuestionDto>(symptomQuestion.Question);
                var options = await _questionOptionRepository.GetQuestionOption(questionDto.Id);
                var optionsDto = new List<GetOptionDto>();
                options.ForEach(x => optionsDto.Add(_mapper.Map<GetOptionDto>(x)));
                GetQuestionOptionsDto questionOption = new()
                {
                    SymptomQuestionId = symptomQuestion.Id,
                    Question = questionDto,
                    Option = optionsDto,
                };
                questionOptions.Add(questionOption);
            }
            return Ok(questionOptions);
        }

        [HttpPost("question/option/cache")]
        public async Task<IActionResult> AddQuestionaireToCache()
        {
            return Ok();
        }

        [HttpPost("track")]
        public async Task<IActionResult> TrackDisorderInCache()
        {
            return Ok();
        }

        [HttpPost("track/ques")]
        public async Task<IActionResult> AddResult()
        {
            return Ok();
        }
    }
}
