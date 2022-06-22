using MimeKit;

namespace LocadoraVipFilmes.Auth.API.Model
{
    public class Mensagem
    {
        public List<MailboxAddress> Destinatarios { get; }
        public string Assunto { get; }
        public string Conteudo { get; }

        public Mensagem(IEnumerable<string> destinatarios, string assunto, int usuarioId, string code)
        {
            this.Destinatarios = new List<MailboxAddress>();
            this.Destinatarios.AddRange(destinatarios.Select(d => new MailboxAddress(d)));
            this.Assunto = assunto;
            this.Conteudo = $"http://localhost:5121/Ativa?usuarioId={usuarioId}&codigoAtivacao={code}";
        }
    }
}
