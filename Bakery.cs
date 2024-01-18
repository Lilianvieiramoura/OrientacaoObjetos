class Bakery
{
  public Bread fabricateBread(int weight)
  {
    return new Bread
    {
      Weight = weight,
      Type = "White"
    };
  }

  public Cake fabricateChocolateCake(string size)
  {
    return new Cake
    {
      Size = size,
      Flavour = "Chocolate"
    };
  }
}

class Bread
{
  string _type = "";

  public int Weight { get; set; }
  public string Type
  {
    get { return _type; }
    set
    {
      if (value != "White" && value != "Wheat")
        throw new ArgumentException("Invalid bread type");

      _type = value;
    }
  }
}

class Cake
{
  public string Size { get; set; }
  public string Flavour { get; set; }
}

// Bakery possui métodos que são capazes de instanciar tanto objetos da classe Bread quanto da classe Cake, mesmo não sendo métodos construtores. São eles:

// O método FabricateBread() é capaz de instanciar um objeto da classe Bread e designar suas propriedades diretamente;

// O método FabricateChocolateCake(), do mesmo modo, pode fabricar deliciosos bolos de chocolate como instâncias da classe Cake.

// Os métodos de Bakery utilizam uma ferramenta chamada object initializer (ou inicializador de objetos), para permitir que façamos a instanciação de objetos com a atribuição de valores das suas propriedades mesmo sem invocar diretamente o construtor da classe que os abstrai.