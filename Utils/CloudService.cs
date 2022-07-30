using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using System.IO;

namespace ADHD.Utils
{
    public class CloudService
    {
        Cloudinary _cloudinary;
        public CloudService()
        {
            Account account = new Account(
                "arshhoadzaihaiiaqnal",
                "673294769152712",
                "thee_jVN__aw12L2KtpWOdI8p0o");

            _cloudinary = new Cloudinary(account);
        }

        public ImageUploadResult? UploadImage(IFormFile file)
        {
            if (file != null)
            {
                var uploadParams = new ImageUploadParams
                {
                    File = new FileDescription(file.FileName, file.OpenReadStream())
                };

                var uploadResult = _cloudinary.Upload(uploadParams);
                return uploadResult;
            }
            return null;
        }

        public void DeleteResource(string publicId)
        {
            var delParams = new DelResParams() { PublicIds = new(){ publicId }, Invalidate = true }; 
            _cloudinary.DeleteResources(delParams);
        }
    }
}
