using System;
using System.Collections.Generic;

namespace EcommerceAPI.Models;

public partial class ItemPedido
{
    public int IdItemPedido { get; set; }

    public int? IdPedido { get; set; }

    public int? IdPrduto { get; set; }

    public int? Quantidade { get; set; }

    public virtual Pedido? IdPedidoNavigation { get; set; }

    public virtual Produto? IdPrdutoNavigation { get; set; }
}
