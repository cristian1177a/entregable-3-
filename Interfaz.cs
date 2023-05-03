namespace TallerApiRestFull;

interface Interfaz
{
    public void crearuno(PokemonDto pok);
    public void crearmuchos(PokemonDto[] poks);
    public void editaruno(int id, PokemonDto pok);
    public void eliminaruno(int id);
    public PokemonDto obteneruno(int id);
    public List<PokemonDto> obtenerportipo(string tipo);

    public List<PokemonDto> obtenerTodo();
    public void eliminarTodos();

    public void editarSegunDefensa(double defensa, PokemonDto pok);
    public void eliminarSegunTipo(string tipo);

    public void eliminasegundefensa(double defensa);
    public List<PokemonDto> obtenersegunnombre(string nombre);

}