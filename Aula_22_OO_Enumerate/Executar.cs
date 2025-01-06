using System;
using System.Collections.Generic;
using System.Linq;

namespace Aula_22_OO_Enumerate
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Criando o cliente
            Client client = new Client("João Silva", "joao.silva@email.com", new DateTime(1985, 5, 15));

            // Criando produtos
            Product product1 = new Product("Produto A", 50.0);
            Product product2 = new Product("Produto B", 100.0);

            // Criando itens de pedido (Quantity, Price)
            OrderItem orderItem1 = new OrderItem(2, product1.Price);  // 2 unidades de Produto A
            OrderItem orderItem2 = new OrderItem(1, product2.Price);  // 1 unidade de Produto B

            // Criando o pedido
            Order order = new Order(DateTime.Now, OrderStatus.PENDING_PAYMENT, client);

            // Adicionando itens ao pedido
            order.addItems(orderItem1);
            order.addItems(orderItem2);

            // Exibindo detalhes do pedido
            Console.WriteLine($"Pedido de {client.Name} ({client.Email}) em {order.Date.ToShortDateString()}");

            Console.WriteLine("\nItens do pedido:");
            foreach (var item in order.Items)
            {
                Console.WriteLine($"- Quantidade: {item.Quantity}, Preço: {item.Price}, Subtotal: {item.SubTotal()}");
            }

            // Exibindo o total do pedido
            double total = order.total();
            Console.WriteLine($"\nTotal do pedido: R$ {total}");

            // Atualizando o status do pedido
            order.Status = OrderStatus.PROCESSING;
            Console.WriteLine($"\nStatus do pedido: {order.Status}");

            // Removendo um item
            order.removeItem(orderItem1);
            Console.WriteLine("\nApós remover o Produto A, o pedido agora contém:");
            foreach (var item in order.Items)
            {
                Console.WriteLine($"- Quantidade: {item.Quantity}, Preço: {item.Price}, Subtotal: {item.SubTotal()}");
            }

            // Novo total após a remoção
            double totalAfterRemoval = order.total();
            Console.WriteLine($"\nNovo total do pedido: R$ {totalAfterRemoval}");
        }
    }
}
