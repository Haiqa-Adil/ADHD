namespace ADHD.Template
{
    public static class EmailVerificationTemplate
    {
        static string EmailBody(string key)
        {
            return String.Format(@"<!doctype html>< html style = '-ms-text-size-adjust: 100%;font-family: sans-serif;line-height: 1.4;-webkit-font-smoothing: antialiased;-webkit-text-size-adjust: 100%;margin: 0 auto !important;padding: 0 !important;width: 100% !important;' >
			< head style = '-ms-text-size-adjust: 100%;' >
			< meta charset = 'utf-8' style = '-ms-text-size-adjust: 100%;' >
			< meta http - equiv = 'X-UA-Compatible' content = 'IE=edge' style = '-ms-text-size-adjust: 100%;' >
			< meta name = 'viewport' content = 'width=device-width, initial-scale=1, shrink-to-fit=no' style = '-ms-text-size-adjust: 100%;' >
			< meta name = 'description' content = 'Password Reset - Ac89 - Email Templates for developers' style = '-ms-text-size-adjust: 100%;' >
			< meta http - equiv = 'Content-Type' content = 'text/html; charset=UTF-8' style = '-ms-text-size-adjust: 100%;' >
			< title style = '-ms-text-size-adjust: 100%;' > Password Reset - Ac89 - Email Templates for developers </ title >
			</ head >
			< body leftmargin = '0' marginwidth = '0' topmargin = '0' marginheight = '0' offset = '0' bgcolor = '#F3F5F9' width = '100%' style = 'margin: 0 auto !important;padding: 0 !important;mso-line-height-rule: exactly;background: #F3F5F9;-ms-text-size-adjust: 100%;font-family: sans-serif;line-height: 1.4;-webkit-font-smoothing: antialiased;-webkit-text-size-adjust: 100%;width: 100% !important;' >
			<table role = 'presentation' align = 'center' valign = 'top' border = '0' cellpadding = '0' cellspacing = '0' height = '100%' width = '100%' bgcolor = '#F3F5F9' style = 'border-spacing: 0;border-collapse: collapse;vertical-align: top;padding: 0;margin: 0;width: 100%;background: #F3F5F9;-ms-text-size-adjust: 100%;mso-table-lspace: 0pt !important;mso-table-rspace: 0pt !important;' >
			< tr style = '-ms-text-size-adjust: 100%;' >< td height = '30' style = 'height: 30px;-ms-text-size-adjust: 100%;mso-table-lspace: 0pt !important;mso-table-rspace: 0pt !important;' >
			< img src = 'https://moiseshp.github.io/email-templates-for-developers/storage/transparent.png' width = '1' height = '1' border = '0' style = 'display: block;border: none;-ms-text-size-adjust: 100%;max-width: 100%;-ms-interpolation-mode: bicubic;' ></ td >
			</ tr >
			< tr style = '-ms-text-size-adjust: 100%;' >
				< td align = 'center' valign = 'top' style = '-ms-text-size-adjust: 100%;mso-table-lspace: 0pt !important;mso-table-rspace: 0pt !important;' >
					< table role = 'presentation' align = 'center' border = '0' cellpadding = '0' cellspacing = '0' width = '600' style = 'max-width: 600px;border-spacing: 0;border-collapse: collapse;vertical-align: top;padding: 0;margin: 0;width: 100%;-ms-text-size-adjust: 100%;mso-table-lspace: 0pt !important;mso-table-rspace: 0pt !important;' >
						< tr style = '-ms-text-size-adjust: 100%;' >
							< td style = '-ms-text-size-adjust: 100%;mso-table-lspace: 0pt !important;mso-table-rspace: 0pt !important;' >
								< p style = 'text-align: center;font-family: Arial, Helvetica, sans-serif;font-size: 12px;color: #99A1B3;margin: 0;padding: 0 20px;line-height: 14px;font-weight: bold;-ms-text-size-adjust: 100%;' >
									To ensure delivery, add < a href = 'mailto:no-reply@company.com' style = 'color: #0069FF;-ms-text-size-adjust: 100%;text-decoration: none;' > no - reply@company.com </ a > to your address book
								</ p >
							</ td >
						</ tr >
					</ table >
				</ td >
			</ tr >
			< tr style = '-ms-text-size-adjust: 100%;' >
				< td height = '20' style = 'height: 20px;-ms-text-size-adjust: 100%;mso-table-lspace: 0pt !important;mso-table-rspace: 0pt !important;' >
					< img src = 'https://moiseshp.github.io/email-templates-for-developers/storage/transparent.png' width = '1' height = '1' border = '0' style = 'display: block;border: none;-ms-text-size-adjust: 100%;max-width: 100%;-ms-interpolation-mode: bicubic;' >
				</ td >
			</ tr >
			< tr style = '-ms-text-size-adjust: 100%;' >
				< td align = 'center' valign = 'top' style = '-ms-text-size-adjust: 100%;mso-table-lspace: 0pt !important;mso-table-rspace: 0pt !important;' >


					< table role = 'presentation' align = 'center' border = '0' cellpadding = '0' cellspacing = '0' width = '600' bgcolor = '#ffffff' style = 'max-width: 600px;border-spacing: 0;border-collapse: collapse;vertical-align: top;padding: 0;margin: 0;width: 100%;background: #ffffff;-ms-text-size-adjust: 100%;mso-table-lspace: 0pt !important;mso-table-rspace: 0pt !important;' >
						< tr style = '-ms-text-size-adjust: 100%;' >
							< td height = '5' style = 'height: 5px;background-color: #0069FF;background-image: linear-gradient(-45deg, #0248FF, #0069FF);-ms-text-size-adjust: 100%;mso-table-lspace: 0pt !important;mso-table-rspace: 0pt !important;' >
								< img src = 'https://moiseshp.github.io/email-templates-for-developers/storage/transparent.png' width = '1' height = '1' border = '0' style = 'display: block;border: none;-ms-text-size-adjust: 100%;max-width: 100%;-ms-interpolation-mode: bicubic;' >
							</ td >
						</ tr >
						< tr style = '-ms-text-size-adjust: 100%;' >
							< td height = '40' style = 'height: 40px;-ms-text-size-adjust: 100%;mso-table-lspace: 0pt !important;mso-table-rspace: 0pt !important;' >
								< img src = 'https://moiseshp.github.io/email-templates-for-developers/storage/transparent.png' width = '1' height = '1' border = '0' style = 'display: block;border: none;-ms-text-size-adjust: 100%;max-width: 100%;-ms-interpolation-mode: bicubic;' >
							</ td >
						</ tr >
						< tr style = '-ms-text-size-adjust: 100%;' >
							< td align = 'center' valign = 'top' style = '-ms-text-size-adjust: 100%;mso-table-lspace: 0pt !important;mso-table-rspace: 0pt !important;' >


								< table role = 'presentation' align = 'center' border = '0' cellpadding = '0' cellspacing = '0' width = '440' style = 'max-width: 440px;border-spacing: 0;border-collapse: collapse;vertical-align: top;padding: 0;margin: 0;width: 100%;-ms-text-size-adjust: 100%;mso-table-lspace: 0pt !important;mso-table-rspace: 0pt !important;' >
									< tr style = '-ms-text-size-adjust: 100%;' >
										< td align = 'center' style = '-ms-text-size-adjust: 100%;mso-table-lspace: 0pt !important;mso-table-rspace: 0pt !important;' >


											< img src = 'https://moiseshp.github.io/email-templates-for-developers/storage/dummylogo-v.png' width = '170' style = 'border: none;display: block;max-width: 170px;width: 100%;-ms-text-size-adjust: 100%;-ms-interpolation-mode: bicubic;' >
										</ td >
									</ tr >
									< tr style = '-ms-text-size-adjust: 100%;' >
										< td height = '40' style = 'height: 40px;-ms-text-size-adjust: 100%;mso-table-lspace: 0pt !important;mso-table-rspace: 0pt !important;' >
											< img src = 'https://moiseshp.github.io/email-templates-for-developers/storage/transparent.png' width = '1' height = '1' border = '0' style = 'display: block;border: none;-ms-text-size-adjust: 100%;max-width: 100%;-ms-interpolation-mode: bicubic;' >
										</ td >
									</ tr >
									< tr style = '-ms-text-size-adjust: 100%;' >
										< td style = '-ms-text-size-adjust: 100%;mso-table-lspace: 0pt !important;mso-table-rspace: 0pt !important;' >
											< h1 style = 'font-family: Arial, Helvetica, sans-serif;font-size: 24px;color: #010E28;font-weight: bold;margin: 0;margin-bottom: 5px;padding: 0;-ms-text-size-adjust: 100%;' >
												Hi, Yennifer Almeyda!
											</ h1 >
											< p style = 'font-family: Arial, Helvetica, sans-serif;font-size: 16px;color: #010E28;margin: 0;padding: 0;-ms-text-size-adjust: 100%;' >
												Forgotten password request {0}
											</ p >
										</ td >
									</ tr >
									< tr style = '-ms-text-size-adjust: 100%;' >
										< td height = '15' style = 'height: 15px;-ms-text-size-adjust: 100%;mso-table-lspace: 0pt !important;mso-table-rspace: 0pt !important;' >
											< img src = 'https://moiseshp.github.io/email-templates-for-developers/storage/transparent.png' width = '1' height = '1' border = '0' style = 'display: block;border: none;-ms-text-size-adjust: 100%;max-width: 100%;-ms-interpolation-mode: bicubic;' >
										</ td >
									</ tr >
									< tr style = '-ms-text-size-adjust: 100%;' >
										< td style = '-ms-text-size-adjust: 100%;mso-table-lspace: 0pt !important;mso-table-rspace: 0pt !important;' >
											< p style = 'font-family: Arial, Helvetica, sans-serif;font-size: 15px;color: #5B6987;margin: 0;padding: 0;line-height: 20px;-ms-text-size-adjust: 100%;' >
												It seems your forgot the password for your account. You can change your password by clicking the button below:
											</ p >
										</ td >
									</ tr >
									< tr style = '-ms-text-size-adjust: 100%;' >
										< td height = '45' style = 'height: 45px;-ms-text-size-adjust: 100%;mso-table-lspace: 0pt !important;mso-table-rspace: 0pt !important;' >
											< img src = 'https://moiseshp.github.io/email-templates-for-developers/storage/transparent.png' width = '1' height = '1' border = '0' style = 'display: block;border: none;-ms-text-size-adjust: 100%;max-width: 100%;-ms-interpolation-mode: bicubic;' >
										</ td >
									</ tr >
									< tr style = '-ms-text-size-adjust: 100%;' >
										< td align = 'center' style = '-ms-text-size-adjust: 100%;mso-table-lspace: 0pt !important;mso-table-rspace: 0pt !important;' >
											< table role = 'presentation' border = '0' cellpadding = '0' cellspacing = '0' width = '440' style = 'max-width: 440px;border-spacing: 0;border-collapse: collapse;vertical-align: top;margin: 0;width: 100%;-ms-text-size-adjust: 100%;mso-table-lspace: 0pt !important;mso-table-rspace: 0pt !important;' >
												< tr style = '-ms-text-size-adjust: 100%;' >
													< td width = '70' style = 'width: 70px;-ms-text-size-adjust: 100%;mso-table-lspace: 0pt !important;mso-table-rspace: 0pt !important;' >
														< img src = 'https://moiseshp.github.io/email-templates-for-developers/storage/transparent.png' width = '1' height = '1' border = '0' style = 'display: block;border: none;-ms-text-size-adjust: 100%;max-width: 100%;-ms-interpolation-mode: bicubic;' >
													</ td >
													< td style = 'font-family: Arial, Helvetica, sans-serif;width: 300px;background-color: #0248FF;background-image: linear-gradient(-45deg, #0248FF, #0069FF);color: #FFF;height: 55px;line-height: 55px;border-radius: 4px;text-align: center;font-weight: bold;-ms-text-size-adjust: 100%;mso-table-lspace: 0pt !important;mso-table-rspace: 0pt !important;' >
														< a href = '#' style = 'font-family: Arial, Helvetica, sans-serif;width: 100%;background-color: #0248FF;background-image: linear-gradient(-45deg, #0248FF, #0069FF);color: #FFF;height: 55px;line-height: 55px;border-radius: 4px;text-align: center;font-weight: bold;display: block;text-decoration: none;cursor: pointer;-ms-text-size-adjust: 100%;' >
															Change password
														</ a >
													</ td >
													< td width = '70' style = 'width: 70px;-ms-text-size-adjust: 100%;mso-table-lspace: 0pt !important;mso-table-rspace: 0pt !important;' >
														< img src = 'https://moiseshp.github.io/email-templates-for-developers/storage/transparent.png' width = '1' height = '1' border = '0' style = 'display: block;border: none;-ms-text-size-adjust: 100%;max-width: 100%;-ms-interpolation-mode: bicubic;' >
													</ td >
												</ tr >
											</ table >
										</ td >
									</ tr >
									< tr style = '-ms-text-size-adjust: 100%;' >
										< td height = '45' style = 'height: 45px;-ms-text-size-adjust: 100%;mso-table-lspace: 0pt !important;mso-table-rspace: 0pt !important;' >
											< img src = 'https://moiseshp.github.io/email-templates-for-developers/storage/transparent.png' width = '1' height = '1' border = '0' style = 'display: block;border: none;-ms-text-size-adjust: 100%;max-width: 100%;-ms-interpolation-mode: bicubic;' >
										</ td >
									</ tr >
									< tr style = '-ms-text-size-adjust: 100%;' >
										< td style = '-ms-text-size-adjust: 100%;mso-table-lspace: 0pt !important;mso-table-rspace: 0pt !important;' >
											< p style = 'font-family: Arial, Helvetica, sans-serif;font-size: 15px;color: #5B6987;margin: 0;padding: 0;line-height: 20px;-ms-text-size-adjust: 100%;' >
												John and the < strong style = 'font-weight: bold;color: #010E28;-ms-text-size-adjust: 100%;' > Company Inc </ strong > Team.
											</ p >
										</ td >
									</ tr >
									< tr style = '-ms-text-size-adjust: 100%;' >
										< td height = '30' style = 'height: 30px;-ms-text-size-adjust: 100%;mso-table-lspace: 0pt !important;mso-table-rspace: 0pt !important;' >
											< img src = 'https://moiseshp.github.io/email-templates-for-developers/storage/transparent.png' width = '1' height = '1' border = '0' style = 'display: block;border: none;-ms-text-size-adjust: 100%;max-width: 100%;-ms-interpolation-mode: bicubic;' >
										</ td >
									</ tr >
									< tr style = '-ms-text-size-adjust: 100%;' >
										< td style = '-ms-text-size-adjust: 100%;mso-table-lspace: 0pt !important;mso-table-rspace: 0pt !important;' >
											< p style = 'font-family: Arial, Helvetica, sans-serif;font-size: 12px;color: #5B6987;margin: 0;padding: 0;line-height: 20px;text-align: left;-ms-text-size-adjust: 100%;' >
												If you're having trouble clicking the password reset button, copy and paste the URL below into your web browser:
											</ p >
										</ td >
									</ tr >
									< tr style = '-ms-text-size-adjust: 100%;' >
										< td height = '10' style = 'height: 10px;-ms-text-size-adjust: 100%;mso-table-lspace: 0pt !important;mso-table-rspace: 0pt !important;' >
											< img src = 'https://moiseshp.github.io/email-templates-for-developers/storage/transparent.png' width = '1' height = '1' border = '0' style = 'display: block;border: none;-ms-text-size-adjust: 100%;max-width: 100%;-ms-interpolation-mode: bicubic;' >
										</ td >
									</ tr >
									< tr style = '-ms-text-size-adjust: 100%;' >
										< td style = '-ms-text-size-adjust: 100%;mso-table-lspace: 0pt !important;mso-table-rspace: 0pt !important;' >
											< p style = 'font-family: Arial, Helvetica, sans-serif;font-size: 12px;color: #5B6987;margin: 0;padding: 0;line-height: 20px;text-align: left;-ms-text-size-adjust: 100%;' >
												https://company.com/password-reset/AbCDeFGhIJKLm
											</ p >
										</ td >
									</ tr >
								</ table >
							</ td >
						</ tr >
						< tr style = '-ms-text-size-adjust: 100%;' >
							< td height = '40' style = 'height: 40px;-ms-text-size-adjust: 100%;mso-table-lspace: 0pt !important;mso-table-rspace: 0pt !important;' >
								< img src = 'https://moiseshp.github.io/email-templates-for-developers/storage/transparent.png' width = '1' height = '1' border = '0' style = 'display: block;border: none;-ms-text-size-adjust: 100%;max-width: 100%;-ms-interpolation-mode: bicubic;' >
							</ td >
						</ tr >
					</ table >
		< table role = 'presentation' align = 'center' valign = 'top' border = '0' cellpadding = '0' cellspacing = '0' width = '600' style = 'border-spacing: 0;border-collapse: collapse;vertical-align: top;padding: 0;margin: 0;-ms-text-size-adjust: 100%;mso-table-lspace: 0pt !important;mso-table-rspace: 0pt !important;' >
						< tr style = '-ms-text-size-adjust: 100%;' >
							< td height = '30' style = 'height: 30px;-ms-text-size-adjust: 100%;mso-table-lspace: 0pt !important;mso-table-rspace: 0pt !important;' >
								< img src = 'https://moiseshp.github.io/email-templates-for-developers/storage/transparent.png' width = '1' height = '1' border = '0' style = 'display: block;border: none;-ms-text-size-adjust: 100%;max-width: 100%;-ms-interpolation-mode: bicubic;' >
							</ td >
						</ tr >
						< tr style = '-ms-text-size-adjust: 100%;' >
							< td align = 'center' valign = 'top' style = '-ms-text-size-adjust: 100%;mso-table-lspace: 0pt !important;mso-table-rspace: 0pt !important;' >
								< table border = '0' cellpadding = '0' cellspacing = '0' width = '440' style = 'max-width: 440px;border-spacing: 0;border-collapse: collapse;vertical-align: top;padding: 0;margin: 0;-ms-text-size-adjust: 100%;mso-table-lspace: 0pt !important;mso-table-rspace: 0pt !important;' >
									< tr style = '-ms-text-size-adjust: 100%;' >
										< td style = '-ms-text-size-adjust: 100%;mso-table-lspace: 0pt !important;mso-table-rspace: 0pt !important;' >
											< p style = 'font-family: Arial, Helvetica, sans-serif;font-size: 12px;color: #99A1B3;margin: 0;padding: 0;line-height: 16px;text-align: center;-ms-text-size-adjust: 100%;' >
												Fermentum varius, < a href = 'mailto:yennifer@mail.com' style = 'color: #0069FF;-ms-text-size-adjust: 100%;text-decoration: none;' > yennifer@mail.com </ a >
												< br style = '-ms-text-size-adjust: 100%;' >
												214 Vestibulum 24th blandit fringilla Consectetur 1929.
												< br style = '-ms-text-size-adjust: 100%;' >
												< a href = '#' style = 'font-weight: bold;color: #99A1B3;-ms-text-size-adjust: 100%;text-decoration: none;' > Terms </ a >
												/
												< a href = '#' style = 'font-weight: bold;color: #99A1B3;-ms-text-size-adjust: 100%;text-decoration: none;' > Privacy Policy </ a >
											</ p >
										</ td >
									</ tr >
								</ table >
							</ td >
						</ tr >
					</ table >
				</ td >
			</ tr >
			< tr style = '-ms-text-size-adjust: 100%;' >
				< td height = '40' style = '-ms-text-size-adjust: 100%;mso-table-lspace: 0pt !important;mso-table-rspace: 0pt !important;' >
					< img src = 'https://moiseshp.github.io/email-templates-for-developers/storage/transparent.png' width = '1' height = '1' border = '0' style = 'display: block;border: none;-ms-text-size-adjust: 100%;max-width: 100%;-ms-interpolation-mode: bicubic;' >
				</ td >
			</ tr >
		</ table >
  </ body >
</ html > ", key);
        }
    }
}
