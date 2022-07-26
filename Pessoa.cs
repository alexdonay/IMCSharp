class Pessoa:Ipessoa
{
    public string nome { get; set; }
    public int idade { get; set; }
    public int endereco { get; set; }

    public double altura { get; set; }
    public double peso { get; set; }

    public Pessoa(string nome, int idade, int endereco)
    {
        this.nome = nome;
        this.idade = idade;
        this.endereco = endereco;
    }

    public double imc(){
      return this.peso / (this.altura * this.altura);
   }
    public double pesoIdeal(){
        return (this.altura * this.altura) * 21.0;
    }
}