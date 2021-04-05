using System;

namespace SistemaCarrosClasse
{

  public class Veiculo 
  {
    //atributo da classe
    private string modelo;
    private string fabricante;
    private int ano;
    private string cor;
    private int numero_portas;
    private string placa;
        
    public string Modelo{
      get{
        return this.modelo;
      }

      set{
        modelo = value;
      }
    }

    public string Fabricante{
      get{
        return this.fabricante;
      }
      set{
        fabricante = value;
      }
    }
         
    public int Ano{
      get{
        return this.ano;
      }
      set{
        ano = value;
      }
    }
        
    public string Cor{
      get{
        return this.cor;
      }
      set{
        cor = value;
      }
    }
        
    public int Numero_Portas{
      get{
        return this.numero_portas;
      }
      set{
        numero_portas = value;
      }
    }
        
    public string Placa{
      get{ 
        return this.placa;  
      }
      set{ 
        placa = value; 
      }
    }
  }

     
  public class Carro : Veiculo
  {
    //  atributos
    private int capacidadePortaMala;
    private Boolean bagageiro;
    private int numero_assentos;
        
    public int CapacidadePortaMala{
      get { 
        return this.capacidadePortaMala; 
      }
      set { 
        capacidadePortaMala = value;
      }
    }

    public Boolean Bagageiro{
      get { 
        return this.bagageiro;
      }
      set { 
        bagageiro = value;
      }
    }

    public String bagageiroEscolha(){
      if(this.bagageiro){
        return "SIM";
      }
      
      return "NÃO";
    }

    public int Numero_assentos{
      get { 
        return this.numero_assentos; 
      }
      set { 
        numero_assentos = value;
      }
    }    
  }

  public class Caminhao : Veiculo
  {
    private int numero_eixos;
    private double peso_maximo_carga;
    private string tipo_cnh;

    public int Numero_eixos{
      get {
        return this.numero_eixos;
      }
      set{
        numero_eixos = value;
      }
    }
    public double Peso_maximo_carga{
      get{
        return this.peso_maximo_carga;
      }
      set{
        peso_maximo_carga = value;
      }
    }
    public string Tipo_cnh{
      get{
        return this.tipo_cnh;
      }
      set{
        tipo_cnh = value;
      }
    }
  }

  class Program
  {
        
    static void Main(string[] args)
    {
            
      int x=0, y=0, menu = 0;
      string s;
      Carro[] carro= new Carro[300];
      Caminhao[] caminhao=new Caminhao[200];
            // caminhao[y] = new Caminhao();
            // 
            // 
      do
      {                
        Console.WriteLine("*** BEM VINDO ***");
        Console.WriteLine("1-Cadastro de Carro");
        Console.WriteLine("2-Cadastro de Caminhão");
        Console.WriteLine("3-Consulta por Placa");
        Console.WriteLine("4-Consulta Caminhão por Modelo/Fabricante");
        Console.WriteLine("5-Consulta Carro por Cor");
        Console.WriteLine("6-Exibir Todos os Carros Cadastrados");
        Console.WriteLine("7-Exibir Todos os Caminhões Cadastrados");
        Console.WriteLine("0-Sair");
        Console.WriteLine("Digite Sua Opção: ");
        menu = int.Parse(Console.ReadLine());
        
        switch(menu)
        {
          
          case 1:
            Console.Clear();
            Console.WriteLine("*** BEM VINDO ***\n");
            do{

              //criar parâmetro aberto?
              carro[x] = new Carro();  
              Console.WriteLine("******** Cadastrar Carro ********\n");

              Console.Write("Modelo: ");
              carro[x].Modelo = Console.ReadLine();

              Console.Write("Marca/Fabricante: ");
              carro[x].Fabricante = Console.ReadLine();
              
              Console.Write("Ano: ");
              carro[x].Ano = int.Parse(Console.ReadLine());

              Console.Write("Cor: ");
              carro[x].Cor = Console.ReadLine();

              Console.Write("Numero de Portas: ");
              carro[x].Numero_Portas = int.Parse(Console.ReadLine());

              Console.Write("Capacidade do PortasMala: ");
              carro[x].CapacidadePortaMala = int.Parse(Console.ReadLine());

              Console.Write("Placa: ");
              carro[x].Placa = Console.ReadLine();

              Console.Write("Bagageiro: \n 1 - SIM \n 2 - NAO \n");

              if(int.Parse(Console.ReadLine()) == 1){
                carro[x].Bagageiro = true;
              }else{
                carro[x].Bagageiro = false;
              }              

              Console.Write("Numero de Assentos: ");
              carro[x].Numero_assentos = int.Parse(Console.ReadLine());

              Console.Clear();

              Console.Write(
                "Modelo: "+carro[x].Modelo+
                "\nMarca/Fabricante: "+carro[x].Fabricante+
                "\nAno: "+carro[x].Ano+
                "\nCor: "+carro[x].Cor+
                "\nNumero de Portas: "+carro[x].Numero_Portas+
                "\nCapacidade do PortasMala: "+carro[x].CapacidadePortaMala+
                "\nPlaca: "+carro[x].Placa+
                "\nBagageiro: "+carro[x].bagageiroEscolha()+
                "\n\n"
              );

              Console.Write("Os Dados Estão Corretos? SIM/NAO ");
              s = Console.ReadLine();
              
              Console.Clear();

              if(s.ToUpper() == "SIM"){
                Console.Write("******** Carro cadastrado com sucesso ********\n\n");
                x++;
              }       

            }while (s.ToUpper() != "SIM");
            break;
          case 2:
            Console.Clear();
            Console.WriteLine("*** BEM VINDO ***\n");
            do{

              caminhao[y] = new Caminhao();  
              Console.WriteLine("******** Cadastrar Caminhão ********\n");

              Console.Write("Modelo: ");
              caminhao[y].Modelo = Console.ReadLine();

              Console.Write("Marca/Fabricante: ");
              caminhao[y].Fabricante = Console.ReadLine();
              
              Console.Write("Ano: ");
              caminhao[y].Ano = int.Parse(Console.ReadLine());

              Console.Write("Cor: ");
              caminhao[y].Cor = Console.ReadLine();

              Console.Write("Numero de Portas: ");
              caminhao[y].Numero_Portas = int.Parse(Console.ReadLine());

              Console.Write("Placa: ");
              caminhao[y].Placa = Console.ReadLine();

              Console.Write("Número Eixos: ");
              caminhao[y].Numero_eixos = int.Parse(Console.ReadLine());

              Console.Write("Peso Máximo Carga: ");
              caminhao[y].Peso_maximo_carga = double.Parse(Console.ReadLine());

              Console.Write("CNH: ");
              caminhao[y].Tipo_cnh = Console.ReadLine();

              Console.Clear();

              Console.Write(
                "Modelo: "+caminhao[y].Modelo+
                "\nMarca/Fabricante: "+caminhao[y].Fabricante+
                "\nAno: "+caminhao[y].Ano+
                "\nCor: "+caminhao[y].Cor+
                "\nNumero de Portas: "+caminhao[y].Numero_Portas+
                "\nNumero de Eixos: "+caminhao[y].Numero_eixos+
                "\nPlaca: "+caminhao[y].Placa+
                "\nPeso Máximo Carga: "+caminhao[y].Peso_maximo_carga+
                "\nCNH: "+caminhao[y].Tipo_cnh+
                "\n\n"
              );

              Console.Write("Os Dados Estão Corretos? SIM/NAO ");
              s = Console.ReadLine();
              
              Console.Clear();

              if(s.ToUpper() == "SIM"){
                Console.Write("******** Caminhão cadastrado com sucesso ********\n\n");
                y++;
              }       

            }while (s.ToUpper() != "SIM");

            break;
          case 3:
            Console.Write("*** CONSULTAR PLACA ****\n\n");

            Console.WriteLine("Digite a placa para consulta: ");
            String placa_consulta = Console.ReadLine();

            for(int i = 0; i < x; i++){

              if(carro[i].Placa.ToUpper() == placa_consulta.ToUpper()){
                Console.Write(
                  "\n\nModelo: "+carro[i].Modelo+
                  "\nMarca/Fabricante: "+carro[i].Fabricante+
                  "\nAno: "+carro[i].Ano+
                  "\nCor: "+carro[i].Cor+
                  "\nNumero de Portas: "+carro[i].Numero_Portas+
                  "\nCapacidade do PortasMala: "+carro[i].CapacidadePortaMala+
                  "\nPlaca: "+carro[i].Placa+
                  "\nBagageiro: "+carro[i].bagageiroEscolha()+
                  "\n\n"
                );
              }

            }

            for(int i = 0; i < y; i++){

              if(caminhao[i].Placa.ToUpper() == placa_consulta.ToUpper()){
                Console.Write(
                  "Modelo: "+caminhao[i].Modelo+
                  "\nMarca/Fabricante: "+caminhao[i].Fabricante+
                  "\nAno: "+caminhao[i].Ano+
                  "\nCor: "+caminhao[i].Cor+
                  "\nNumero de Portas: "+caminhao[i].Numero_Portas+
                  "\nNumero de Eixos: "+caminhao[i].Numero_eixos+
                  "\nPlaca: "+caminhao[i].Placa+
                  "\nPeso Máximo Carga: "+caminhao[i].Peso_maximo_carga+
                  "\nCNH: "+caminhao[i].Tipo_cnh+
                  "\n\n"
                );
              }

            }

            break;         
          case 4: 
            Console.Write("*** CONSULTAR CAMINHÃO POR MODELO/MARCA ****\n\n");

            Console.WriteLine("Digite a cor para consulta: ");
            String consulta = Console.ReadLine();

            for(int i = 0; i < y; i++){

              if(caminhao[i].Modelo.ToUpper() == consulta.ToUpper()){
                Console.Write(
                  "Modelo: "+caminhao[i].Modelo+
                  "\nMarca/Fabricante: "+caminhao[i].Fabricante+
                  "\nAno: "+caminhao[i].Ano+
                  "\nCor: "+caminhao[i].Cor+
                  "\nNumero de Portas: "+caminhao[i].Numero_Portas+
                  "\nNumero de Eixos: "+caminhao[i].Numero_eixos+
                  "\nPlaca: "+caminhao[i].Placa+
                  "\nPeso Máximo Carga: "+caminhao[i].Peso_maximo_carga+
                  "\nCNH: "+caminhao[i].Tipo_cnh+
                  "\n\n"
                );
              }else if(caminhao[i].Fabricante.ToUpper() == consulta.ToUpper()){
                Console.Write(
                  "Modelo: "+caminhao[i].Modelo+
                  "\nMarca/Fabricante: "+caminhao[i].Fabricante+
                  "\nAno: "+caminhao[i].Ano+
                  "\nCor: "+caminhao[i].Cor+
                  "\nNumero de Portas: "+caminhao[i].Numero_Portas+
                  "\nNumero de Eixos: "+caminhao[i].Numero_eixos+
                  "\nPlaca: "+caminhao[i].Placa+
                  "\nPeso Máximo Carga: "+caminhao[i].Peso_maximo_carga+
                  "\nCNH: "+caminhao[i].Tipo_cnh+
                  "\n\n"
                );
              }
              
            }
             
            break;

          case 5:
            Console.Write("*** CONSULTAR CARRO POR COR ****\n\n");

            Console.WriteLine("Digite a cor para consulta: ");
            String cor_consulta = Console.ReadLine();

            for(int i = 0; i < x; i++){

              if(carro[i].Cor.ToUpper() == cor_consulta.ToUpper()){
                Console.Write(
                  "\n\nModelo: "+carro[i].Modelo+
                  "\nMarca/Fabricante: "+carro[i].Fabricante+
                  "\nAno: "+carro[i].Ano+
                  "\nCor: "+carro[i].Cor+
                  "\nNumero de Portas: "+carro[i].Numero_Portas+
                  "\nCapacidade do PortasMala: "+carro[i].CapacidadePortaMala+
                  "\nPlaca: "+carro[i].Placa+
                  "\nBagageiro: "+carro[i].bagageiroEscolha()+
                  "\n\n"
                );
              }
              
            }

            break;        
            
          case 6: 
            Console.Write("*** EXIBIR TODOS MODELOS DE CARRO ****\n");

            for(int i = 0; i < x; i++){
              Console.Write("Modelo: "+carro[i].Modelo+"\n");
            }

            break;         
          
          case 7: 
            Console.Write("*** EXIBIR TODOS MODELOS DE CAMINHÃO ****\n");

            for(int i = 0; i < y; i++){
              Console.Write("Modelo: "+caminhao[i].Modelo+"\n");
            }

            break; 
        }     
      }while (menu != 0);
    }
  }
}
