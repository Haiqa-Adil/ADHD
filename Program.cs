using ADHD.Configuration;
using ADHD.Data;
using ADHD.Middleware.disorder;
using ADHD.Middleware.exercise;
using ADHD.Repository.disorder;
using ADHD.Repository.exercise;
using ADHD.Utils;
using ADHD.UtilService;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add Database Setting
builder.Services.AddDbContext<DataContext>(options =>
{
    var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
});

// Add Authentication Configuration
builder.Services.Configure<JwtConfig>(builder.Configuration.GetSection("JwtConfig"));

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(jwt =>
{
    var key = Encoding.ASCII.GetBytes(builder.Configuration.GetSection("JwtConfig:Secret").Value);

    jwt.SaveToken = true;
    jwt.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(key),
        ValidateIssuer = false, // for dev
        ValidateAudience = false, // for dev
        RequireExpirationTime = false, // for dev -- needs to be updated when refresh token is added
        ValidateLifetime = true
    };
});

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddEntityFrameworkStores<DataContext>();

//AutoMapper Configuration
builder.Services.AddAutoMapper(typeof(Program));

//Add email configuration
var emailConfig = builder.Configuration.GetSection("EmailConfig").Get<EmailConfig>();
builder.Services.AddSingleton(emailConfig);

//Configure Dependency Injection
builder.Services.AddScoped<IMailService, MailService>();
builder.Services.AddScoped<IAuthenticationToken, AuthenticationToken>();
builder.Services.AddScoped<IDisorderRepository, DisorderRepository>();
builder.Services.AddScoped<ISymptomRepository, SymptomRepository>();
builder.Services.AddScoped<ISymptomQuestionRepository, SymptomQuestionRepository>();
builder.Services.AddScoped<IQuestionRepository, QuestionRepository>();
builder.Services.AddScoped<IOptionRepository, OptionRepository>();
builder.Services.AddScoped<IQuestionOptionRepository, QuestionOptionRepository>();
builder.Services.AddScoped<IStoryRepository, StoryRepository>();
builder.Services.AddScoped<IMoodJournalRepository, MoodJournalRepository>();
builder.Services.AddScoped<IDailyMoodRepository, DailyMoodRepository>();

// Add services to the container.

builder.Services.AddControllers().AddNewtonsoftJson();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
