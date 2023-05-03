namespace TallerApiRestFull;

class ClasePokemon : Interfaz
{
    List<PokemonDto> BD;
    public ClasePokemon()
    {
        this.BD = new List<PokemonDto>();
    }
    public void crearmuchos(PokemonDto[] poks)
    {
        foreach (PokemonDto pok in poks)
        {
            crearuno(pok);
        }
    }

    public void crearuno(PokemonDto pok)
    {
        Boolean habilidad = true, defen = false;
        for (int i = 0; i < pok.habilidades.Length; i++)
        {
            if (pok.habilidades.ElementAt(i) <= 40 && pok.habilidades.ElementAt(i) >= 0)
            {
                habilidad = true;
            }
            else
            {
                habilidad = false;
                return;
            }
        }
        if (pok.defensa <= 30 && pok.defensa >= 1)
        {
            defen = true;
        }
        if (defen == true && habilidad == true)
        {
            this.BD.Add(pok);
        }

    }

    public void eliminasegundefensa(double defensa)
    {
        this.BD.RemoveAll(pok => pok.defensa == defensa);
    }

    public void editarSegunDefensa(double defensa, PokemonDto pok)
    {
        PokemonDto pokelegido = this.BD.Single(pok => pok.defensa == defensa);
        pokelegido = pok;
        int index = this.BD.IndexOf(pokelegido);
         if (index >= 0 && index < BD.Count)
        {
            BD[index] = pok;
        }
    }

    public void editaruno(int id, PokemonDto pok)
    {
        PokemonDto pokactualizar = this.BD.Single(pokemon => pokemon.id == id);
        pokactualizar = pok;
        int index = this.BD.IndexOf(pokactualizar);
        if (index >= 0 && index < BD.Count)
        {
            BD[index] = pok;
        }
    }

    public void eliminarSegunTipo(string tipo)
    {
        this.BD.RemoveAll(pok => pok.tipo == tipo);
    }

    public void eliminarTodos()
    {
        this.BD.Clear();
    }

    public void eliminaruno(int id)
    {
        this.BD.RemoveAll(pok => pok.id == id);
    }

    public List<PokemonDto> obtenerportipo(string tipo)
    {
        var obtengoLista = this.BD.Where(pok => pok.tipo == tipo);
        List<PokemonDto> lista = obtengoLista.ToList();
        return lista;
    }

    public List<PokemonDto> obtenersegunnombre(string nombre)
    {
        var obtengoLista = this.BD.Where(pok => pok.nombre == nombre);
        List<PokemonDto> lista = obtengoLista.ToList();
        return lista;
    }

    public List<PokemonDto> obtenerTodo()
    {
        return this.BD;
    }

    public PokemonDto obteneruno(int id)
    {
        PokemonDto pok = this.BD.Single(pok => pok.id == id);
        return pok;
    }
}