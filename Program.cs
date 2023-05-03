using TallerApiRestFull;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
ClasePokemon pokemon=new ClasePokemon();


app.MapPost("/api/crearmuchos",(PokemonDto[] poks)=>{
    pokemon.crearmuchos(poks);
});
app.MapPost("/api/crearuno",(PokemonDto pok)=>{
    pokemon.crearuno(pok);
});

app.MapDelete("/api/eliminasegundefensa/{defensa}",(double defensa)=>{
    pokemon.eliminasegundefensa(defensa);
});

app.MapPut("/api/editardefensa/{defensa}",(double defensa,PokemonDto pok)=>{
    pokemon.editarSegunDefensa(defensa,pok);
});
app.MapPut("/api/editaruno/{id}",(int id,PokemonDto pok)=>{
    pokemon.editaruno(id,pok);
});


app.MapDelete("/api/eliminarseguntipo/{tipo}",(string tipo)=>{
    pokemon.eliminarSegunTipo(tipo);
});
app.MapDelete("/api/eliminatodo",()=>{
    pokemon.eliminarTodos();
});
app.MapDelete("/api/eliminauno/{id}",(int id)=>{
    pokemon.eliminaruno(id);
});


app.MapGet("/api/obtenertipo/{tipo}", (string tipo) => {
    return Results.Ok(pokemon.obtenerportipo(tipo));
});
app.MapGet("/api/obtenernombre/{nombre}", (string nombre) => {
    return Results.Ok(pokemon.obtenersegunnombre(nombre));
});
app.MapGet("/api/obtenertodo", () => {
    return Results.Ok(pokemon.obtenerTodo());
});
app.MapGet("/api/obteneruno/{id}", (int id) => {
    return Results.Ok(pokemon.obteneruno(id));
});

app.Run();
