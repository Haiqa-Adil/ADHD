using ADHD.Dto.user;
using ADHD.Utils;
using ADHD.UtilService;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ADHD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;

        private readonly IConfiguration _configuration;
        private IMailService _mail;
        private IAuthenticationToken _authenticationToken;
        public AuthenticationController(
            UserManager<IdentityUser> userManager,
            IConfiguration configuration,
            IMailService mail,
            IAuthenticationToken authenticationToken)
        {
            _userManager = userManager;
            _configuration = configuration;
            _mail = mail;
            _authenticationToken = authenticationToken;
        }

        [HttpPost("signup")]
        public async Task<IActionResult> SignUp([FromForm]UserDto requestDto)
        {
            if (ModelState.IsValid)
            {
                // We need to check if the email already exist
                   var user_exist = await _userManager.FindByEmailAsync(requestDto.Email);

                
                if (user_exist != null)
                {
                    return BadRequest("Email already exist");
                }

                // create a user
                var new_user = new IdentityUser()
                {
                    Email = requestDto.Email,
                    UserName = requestDto.Email,
                    EmailConfirmed = false
                };

                var is_created = await _userManager.CreateAsync(new_user, requestDto.Password);
                
                if (is_created.Succeeded)
                {
                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(new_user);

                    //var email_body = ;

                    // https://localhost:8080/authentication/verifyemail/userid=sdas&code=dasdasd 
                    var callback_url = Request.Scheme + "://" + Request.Host + Url.Action("ConfirmEmail", "Authentication",
                        new { userId = new_user.Id, code = code });

                    var body = String.Format("Please confirm your email address <a href=\"{0}\">Click here </a> ",
                        callback_url);
                    List<string> to = new() { requestDto.Email };
                    Message message = new("05haiqaadillive@gmail.com", to, "Verify Email ", body);

                     var sended = _mail.SendEmail(message);

                    var cloudService = new CloudService();
                    Console.WriteLine(cloudService.UploadImage(requestDto.Image));

                    if (sended)
                        return Ok("Please verify your email, through the verification email we have just sent.");

                    return Ok("Please request an email verification link");

                }
            }   
            return BadRequest("Server Error");
        }

        [Route("ConfirmEmail")]
        [HttpGet]
        public async Task<IActionResult> ConfirmEmail(string userId, string code)
        {
            if (userId == null || code == null)
            {
                return BadRequest(
                    "Invalid email confirmation url");
            }

            var user = await _userManager.FindByIdAsync(userId);

            if (user == null)
            {
                return BadRequest(
                    "Invalid email parameter");
            }

            //code =  Encoding.UTF8.GetString(Convert.FromBase64String(code));
            var result = await _userManager.ConfirmEmailAsync(user, code);
            var status = result.Succeeded
                ? "Thank you for confirming your mail"
                : "Your email is not confirmed, please try again later";

            return Ok(status);
        }

        [Route("Login")]
        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginDto requestDto )
        {
            if (ModelState.IsValid)
            {
                // Check if the user exist
                var existing_user = await _userManager.FindByEmailAsync(requestDto.Email);

                if (existing_user == null)
                    return BadRequest(
                        "Invalid payload"
                    );

                if (!existing_user.EmailConfirmed)
                    return BadRequest(
                        "Email needs to be confirmed");

                var isCorrect = await _userManager.CheckPasswordAsync(existing_user, requestDto.Password);

                if (!isCorrect)
                    return BadRequest(
                        "Invalid credentials");

                var jwtToken = _authenticationToken.CreateToken(existing_user);

                return Ok(jwtToken);
            }

            return BadRequest(
                "Invalid payload");
        }

    }
}
