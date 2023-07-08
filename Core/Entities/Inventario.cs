namespace Core.Entities;

public class Inventario
{
    //Definimos los atributos de las entidades tablas de Inventarios
    //escrbimos sus referencias

    public int Id { get; set; }
    public int Id_bodega { get; set; }
    public int Id_producto { get; set; }
    public int Cantidad { get; set; }
    public int Created_by { get; set; }
    public int Updated_by { get; set; }
    public DateTime Created_at { get; set; }
    public DateTime Updated_at { get; set; }
    public DateTime Deleted_at { get; set; }

    // definimos los ICollection a las tablas con la que se relaciona
    public ICollection<Historial> ? Historiales { get; set; }

    //referenciamos la entidad a la que esta unida
    public Producto ? Producto { get; set; }

    public User ? UserUno { get; set; }
    public User ? UserDos { get; set; }
    
    public Bodega ? Bodega { get; set; }

        
}
