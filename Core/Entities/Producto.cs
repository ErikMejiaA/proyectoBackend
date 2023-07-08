namespace Core.Entities;

public class Producto
{
     //Entidad Hija_padre
    //realizamos las referencias de la entidad de Productos
    //definicion de los atributos de la entidad Productos

    public int Id { get; set; }
    public string ? Nombre { get; set; }
    public string ? Descripcion { get; set; }
    public int Estado { get; set;}
    public int Created_by { get; set; }
    public int Update_by { get; set; }
    public DateTime Created_at { get; set; }
    public DateTime Update_at { get; set; }
    public DateTime Deleted_at { get; set; }

    // definimos los ICollection a las tablas con la que se relaciona
    public ICollection<Inventario> ? Inventarios { get; set; }

    //referenciamos la entidad a la que esta unida
    public User ? UserUno { get; set; }
    public User ? UserDos { get; set; }
    
        
}
