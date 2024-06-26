using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace atv
{
    public class GerenciadorCliente
    {
        List<Cliente> clientes = new List<Cliente>();

   
        public GerenciadorCliente()   
        {
            clientes = new List<Cliente>();
        }

        public void AdcCliente(Cliente cliente)
        {
            clientes.Add(cliente);
        }

        public void ExcluirCliente(Cliente cliente)  
        {
            clientes.Remove(cliente);
        }

        public void ListarCliente()    
        {
            foreach (Cliente cliente in clientes)
            {
               cliente.ExibirDetalhes(); 
            }
            
        }
        
        
        
    }
}
