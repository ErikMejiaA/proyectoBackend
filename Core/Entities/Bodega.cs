namespace Core.Entities;

public class Bodega
{
    //Entidad Hija_padre
    //realizamos las referencias de la entidad de Bodegas
    //definicion de los atributos de la entidad Bodegas

    public int Id { get; set; }
    public string ? Nombre { get; set; }
    public int Id_responsable { get; set; }
    public int Estado { get; set; }
    public int Created_by { get; set; }
    public int Update_by { get; set; }
    public DateTime Created_at { get; set; }
    public DateTime Updated_at { get; set; }
    public DateTime Deleted_at { get; set; }

     // definimos los ICollection a las tablas con la que se relaciona
     public ICollection<Inventario> ? Inventarios { get; set; }
     
     public ICollection<Historial> ? HistorialesUno { get; set; }
     public ICollection<Historial> ? HistorialesDos { get; set; }

    //referenciamos la entidad a la que esta unida
    public User ? UserUno { get; set; }
    public User ? UserDos { get; set; }
    public User ? UserTres { get; set; }

     
        
}
