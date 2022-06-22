using LocadoraVipFilmes.Auth.API.Model;
using MailKit.Net.Smtp;
using MimeKit;


namespace LocadoraVipFilmes.Auth.API.Services
{
    public class EmailService
    {
        private IConfiguration _configuration;

        public EmailService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void EnviarEmail(string[] destinatarios, string assunto, int usuarioId, string code)
        {
            Mensagem msg = new Mensagem(destinatarios, assunto, usuarioId, code);
            var from = _configuration.GetValue<string>("EmailSettings:From");
            var mensagemEmail = CriarCorpoEmail(msg, from);
            EnviarEmail(mensagemEmail);
        }

        private void EnviarEmail(MimeMessage mensagemEmail)
        {
            using (var client = new SmtpClient())
            {
                try
                {
                    var smtpServer = _configuration.GetValue<string>("EmailSettings:SmtpServer");
                    var port = _configuration.GetValue<int>("EmailSettings:Port");
                    var from = _configuration.GetValue<string>("EmailSettings:From");
                    var password = _configuration.GetValue<string>("EmailSettings:Password");

                    client.Connect(smtpServer, port, true);
                    client.AuthenticationMechanisms.Remove("XOUATH2");
                    client.Authenticate(from, password);

                    client.Send(mensagemEmail);
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    client.Disconnect(true);
                    client.Dispose();
                }
            }
        }

        private MimeMessage CriarCorpoEmail(Mensagem msg, string from)
        {
            var mensagemEmail = new MimeMessage();
            mensagemEmail.From.Add(new MailboxAddress(from));
            mensagemEmail.To.AddRange(msg.Destinatarios);
            mensagemEmail.Subject = msg.Assunto;
            mensagemEmail.Body = new TextPart(MimeKit.Text.TextFormat.Text)
            {
                 Text = msg.Conteudo
            };

            return mensagemEmail;
        }
    }
}
