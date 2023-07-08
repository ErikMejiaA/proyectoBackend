namespace Core.Entities;

public class User
{

    //Entidad Padre
    //realizamos las referencias de la entidad de Users
    //definicion de los atributos de la entidad Users
    public int Id { get; set; }
    public string ? Nombre { get; set; }
    public string ? Email { get; set; }
    public DateTime Email_verified_at { get; set; }
    public int Estado { get; set; }
    public int Created_by { get; set;}
    public int Update_by { get; set; }
    public string ? Foto { get; set; }
    public string ? Password { get; set; }
    public DateTime Created_at { get; set;}
    public DateTime Update_at { get; set; }
    public DateTime Deleted_at { get; set; }

    // definimos los ICollection a las tablas con la que se relaciona
    public ICollection<Producto> ? ProductosUno { get; set; }
    public ICollection<Producto> ? ProductosDos { get; set; }

    public ICollection<Inventario> ? InventariosUno { get; set; }
    public ICollection<Inventario> ? InventariosDos { get; set; }

    public ICollection<Bodega> ? BodegasUno { get; set; }
    public ICollection<Bodega> ? BodegasDos { get; set; }
    public ICollection<Bodega> ? BodegasTres { get; set; }
    
    public ICollection<Historial> ? HistorialesUno { get; set; }
    public ICollection<Historial> ? HistorialesDos { get; set; }

}
