# Crie seu próprio Captcha usando CSharp

Olá pessoal, hoje eu quero mostrar como criar seu próprio captcha usando a linguagem C# e a ferramenta Visual Studio da Microsoft. O mais importante é que não utilizaremos nenhum software externo ao seu, isso porque muitos já são capturados por ferramentas. 

O problema:

- O grande problema hoje em dia é que boots ou softwares automáticos entram em sites e mandam e-mail de anuncios ou até vírus. 
- Outro grande problema é que todos os dias você vai receber e-mails e uma você ou seu cliente vai clicar e ser infectado.

Eu fiz um teste em meu site, sem o capta eu recebia todos os dias pessoas até querendo comprar o site ou o conteúdo, mas eu precisa fazer algumas coisas, entrar no site ou dar até dinheiro. Depois de criar o meu próprio capta e colocar, esses e-mails pararam e nenhum mais foi recebido.

Isso porque eu coloquei uma lógica interna e indetectável pelos boots. Vamos ver como foi desenvolvido.

**Desenvolvimento**

**Página aspx**

Na página de contato foi colocado apenas um *label* chamado lblSoma a mais.

	<asp:Label ID="lblSoma" runat="server" ForeColor="Red"></asp:Label> &nbsp;
	<asp:TextBox runat="server" ID="txtSoma" TextMode="Number" MaxLength="4"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtSoma"Display="Dynamic" ErrorMessage="*" SetFocusOnError="True"></asp:RequiredFieldValidator>

	<br /><br />
	<asp:Button ID="cmdEnviar" CssClass="btn-lg" Text="Enviar" runat="server" OnClick="cmdEnviar_Click" />
	<asp:Label ID="lblResultado" runat="server" ForeColor="Red"></asp:Label>

Código 1.1 - *Label* da página

Não vou colocar aqui toda a página de contato, só mesmo o código que precisei colocar e assim basta você colocar na sua página que já está pronta.

**C# Code**

Para gerar o captcha automático é necessário gerar um método que executa na entrada da página e para isso eu dei o nome de *RandomSoma()*. A.

Para mais detalhes acesse o site [https://www.ecode10.com/artigo/3045/crie-seu-proprio-captcha-usando-csharp](https://www.ecode10.com/artigo/3045/crie-seu-proprio-captcha-usando-csharp)
