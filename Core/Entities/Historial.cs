namespace Core.Entities;

public class Historial
{
    
    //Definimos los atributos de las entidades tablas de Inventarios
    //escrbimos sus referencias

    public int Id { get; set; }
    public int Cantidad { get; set; }
    public int Id_bodega_origen { get; set; }
    public int Id_bodega_destino { get; set; }
    public int Id_inventario { get; set;}
    public int Created_by { get; set; }
    public int Update_by { get; set; }
    public DateTime Created_at { get; set; }
    public DateTime Updated_at { get; set; }
    public DateTime Deleted_at { get; set; }

    //referenciamos la entidad a la que esta unida
    public Inventario ? Inventario { get; set; }

    public Bodega ? BodegaUno { get; set; }
    public Bodega ? BodegaDos { get; set; }
    
    public User ? UserUno { get; set; }
    public User ? UserDos { get; set; }


}
