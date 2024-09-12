public class Conta  

{
    public string nome;
    public int numero;
    public int agencia;
    public int cpf;


 public Conta(string nomeDoProprietario, int numeroDaConta, int agenciaDoBanco, int numeroDoCpf)
 {
     nome = nomeDoProprietario;
     numero = numeroDaConta;
     agencia = agenciaDoBanco;
     cpf = numeroDoCpf;
 }

}