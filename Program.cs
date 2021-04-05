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

              Console.Write("Capacidade do Porta Malas: ");
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
            
            break;
          case 3:
            /*do{
                        // consulta por Placa
                          string cp; //consulta placa
                          int a=0;
                          Console.WriteLine("------Consultar por Placa------");
                          Console.Write("Placa: ");
                          cp = Console.ReadLine();
                           for (a = 0; a < 500; a++)
                        {
                            if (carro[x].Placa.ToUpper() == cp.ToUpper() || caminhao[y].Placa.ToUpper() == cp.ToUpper())
                            {
                                Console.WriteLine("Carros: {0} \r\nCaminhões: {1}", carro[x].Placa, caminhao[y].Placa);
                            }
                        }
                          Console.WriteLine("Digite SIM para sair desta opção!");
                           s = Console.ReadLine();
            }while (s.ToUpper() != "SIM");*/
            break;         
          case 4: 
            /*do{
                        // consulta caminhão por modelo/Marca 
                        string cm; //consulta modelo
                        int a=0;
                        Console.WriteLine("-------Consulta Caminhão por Modelo/Marca-------");
                        Console.Write("Modelo/Marca: ");
                        cm = Console.ReadLine();
                          for (a = 0; a < 200; a++)
                        {
                            if (caminhao[y].Modelo.ToUpper() == cm.ToUpper() || caminhao[y].Fabricante.ToUpper() == cp.ToUpper())
                            {
                                Console.WriteLine("Caminhões: {0}", caminhao[y].Modelo, caminhao[y].Fabricante);
                            }
                        }
                        Console.WriteLine("Digite SIM para sair desta opção!");
                }while (s.ToUpper() != "SIM");*/
              break;

          case 5:
              /*do{
                        // consultar carro por cor
                        string cc; //consulta cor
                        int a=0;
                        Console.WriteLine("-------Consulta Carro por Cor------");
                        Console.Write("Cor: ");
                        cc = Console.ReadLine();
                           for (a = 0; a < 300; a++)
                        {
                            if (carro[x].Cor.ToUpper() == cc.ToUpper())
                            {
                                Console.WriteLine("Carros: {0}", carro[x].Cor);
                            }
                        }
                        Console.WriteLine("Digite SIM para sair desta opção!");
                }while (s.ToUpper() != "SIM");*/
            break;        
            
          case 6: 
              /*do{
                       Console.WriteLine("-------Exibir Todos Carros Cadastrados-------") ;
                       Console.WriteLine("Carros: {0}",carro[]);
                       Console.WriteLine("Digite SIM para sair desta opção!");
                      
                }while (s.ToUpper() != "SIM");*/
            break;         
          
          case 7: 
              /*do{
                      Console.WriteLine("-------Exibir Todos Caminhões Cadastrados-------") ;
                       Console.WriteLine("Caminhões: {0}",caminhao[X]);
                       Console.WriteLine("Digite SIM para sair desta opção!");
              }while (s.ToUpper() != "SIM");*/
            break;
        }     
      }while (menu != 0);
    }
  }
}