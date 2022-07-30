using ADHD.Dto;
using ADHD.Dto.exercise;
using ADHD.Middleware.exercise;
using ADHD.Models.Exercise;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace ADHD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExerciseController : Controller
    {
        private IMoodJournalRepository moodJournalRepository;
        private IDailyMoodRepository dailyMoodRepository;
        private IStoryRepository storyRepository;
        private IMapper mapper;
        public ExerciseController(IDailyMoodRepository dailyMoodRepository, 
            IStoryRepository storyRepository, 
            IMoodJournalRepository moodJournalRepository,
            IMapper mapper)
        {
            this.moodJournalRepository = moodJournalRepository;
            this.dailyMoodRepository = dailyMoodRepository;
            this.storyRepository = storyRepository;
            this.mapper = mapper;
        }

        [HttpPost("journal")]
        public async Task<IActionResult> AddMoodJournal(MoodJournalDto moodJournalDto)
        {
            var moodJournal = mapper.Map<MoodJournal>(moodJournalDto);
            await moodJournalRepository.AddMoodJournal(moodJournal);
            return Ok(moodJournal);
        }

        [HttpPost("daily/mood")]
        public async Task<IActionResult> AddDailyMood(DailyModDto dailyMoodDto)
        {
            var dailyMood = mapper.Map<DailyMood>(dailyMoodDto);
            await dailyMoodRepository.AddMood(dailyMood);
            return Ok(dailyMood);
        }

        [HttpPost("story")]
        public async Task<IActionResult> AddStory(StoryDto storyDto)
        {
            var story = mapper.Map<Story>(storyDto);
            await storyRepository.AddStory(story);
            return Ok(story);
        }

        [HttpGet("journal")]
        public async Task<IActionResult> GetMoodJournal([FromQuery]GetDataByDates getDataByDates)
        {
            var moodJournals = await moodJournalRepository.GetMoodJournals();
            return Ok(moodJournals);
        }

        [HttpGet("mood/journal")]
        public async Task<IActionResult> GetDailyMood([FromQuery] GetDataByDates getDataByDates)
        {
            var dailyMoods = await dailyMoodRepository.GetMoodList();
            return Ok(dailyMoods);
        }


        [HttpGet("stories")]
        public async Task<IActionResult> GetStories()
        {
            var stories = await storyRepository.GetStories();
            return Ok(stories);
        }


        [HttpGet("story/{storyId}")]
        public async Task<IActionResult> GetStoryById(int storyId)
        {
            var story = await storyRepository.GetStoryById(storyId);
            return Ok(story);
        }
    }
}
