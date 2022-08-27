using ADHD.Dto;
using ADHD.Dto.booking;
using ADHD.Dto.disorder;
using ADHD.Dto.exercise;
using ADHD.Dto.student;
using ADHD.Dto.user;
using ADHD.Models;
using ADHD.Models.booking;
using ADHD.Models.Disorder;
using ADHD.Models.Exercise;
using AutoMapper;

namespace ADHD.Mapper;

public class Mappers :Profile
{
    public Mappers()
    {
        CreateMap<User, UserDto>()
            .ReverseMap();
        CreateMap<Disorder, DisorderDto>()
            .ReverseMap();
        CreateMap<Disorder, GetDisorderDto>()
            .ReverseMap();
        CreateMap<Symptom, SymptomDto>()
            .ReverseMap();
        CreateMap<Symptom, GetSymptomDto>()
            .ReverseMap();
        CreateMap<Question, QuestionDto>()
            .ReverseMap();
        CreateMap<Option, OptionDto>()
            .ReverseMap();
        CreateMap<Question, GetQuestionDto>()
            .ReverseMap();
        CreateMap<Option, GetOptionDto>()
            .ReverseMap();
        CreateMap<SymptomQuestion, SymptomQuestionDto>()
            .ReverseMap();
        CreateMap<QuestionOption, QuestionOptionDto>().
            ReverseMap();
        CreateMap<Booking, BookingDto>()
            .ReverseMap();
        CreateMap<BookingReschedule, BookingRescheduleDto>()
            .ReverseMap();
        CreateMap<BookingSession, BookingSessionDto>()
            .ReverseMap();
        CreateMap<MoodJournal, MoodJournalDto>()
            .ReverseMap();
        CreateMap<DailyMood, DailyModDto>()
                    .ReverseMap();
        CreateMap<Story, StoryDto>()
                    .ReverseMap();
        CreateMap<DisorderResult, AddSymptomScoreDto>()
                    .ReverseMap();
        CreateMap<Student, AddStudentDto>()
                    .ReverseMap();
        CreateMap<Student, GetStudentDto>()
                    .ReverseMap();
    }
}
