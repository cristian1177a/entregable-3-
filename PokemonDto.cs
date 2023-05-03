namespace TallerApiRestFull;

class PokemonDto
{
    public int id { get; set; }
     public string nombre { get; set; }
    public string tipo { get; set; }
    public int[] habilidades { get; set; }
    public double defensa { get; set; }
}