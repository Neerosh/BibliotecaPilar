# BibliotecaPilar

## Requer .NET 6

<p>A conexão com o SQL Server foi feita no arquivo App.config. Por padrão são criados 3 livros e 2 usuários ao iniciar o programa 
caso o banco esteja vazio, um sendo tipo Padrão:</p>
<ul>
  <li>Usuário: usuario</li>
  <li>Senha: 123</li>
</ul>
<p>E outro tipo Administrador:</p>
<ul>
  <li>Usuário: admin</li>
  <li>Senha: admin</li>
</ul>
<p>A taxa base para o cálculo da multa esta definida no código como R$ 50,00</p>
<p>O estado do livro pode ser modificado pelos usuários que são administradores realizando as operações
Retirar Livro (coloca o livro como Retirado) e Devolver Livro (coloca o livro como Disponível).</p>
<p>Quando um usuário realiza a reserva do livro e o estado do livro se encontra em Disponível o sistema realiza a alteração automaticamente para Reservado.</p>
<p>Os icones foram pegos do site: <a target="_blank" href="https://icons8.com">Icons8</a>
<p>
