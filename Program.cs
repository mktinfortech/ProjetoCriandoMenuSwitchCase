


string? opcoes;

while(true)
{
       
    System.Console.WriteLine("\n =========================== Estruras Condicionais com Switch Case==================");
    System.Console.WriteLine("\n\n         =========================== Criando Um Menu ==================");

   

    Console.Write("\n\n      1 = Adicionar");
    Console.Write("     2 = Excluir");
    Console.Write("     3 = Listar");
    Console.WriteLine("     4 = Atualizar");

    opcoes = Console.ReadLine();

    
         Console.Clear();

   switch(opcoes)
   {
    
        
        case "1":
        Console.WriteLine("Adicionando...");
        break;
         case "2":
        Console.WriteLine("Excluindo...");
        break;
         case "3":
        Console.WriteLine("Listando...");
        break;
         case "4":
        Console.WriteLine("Atualizando...");
        break;

        default:
        Console.WriteLine("Opção Invalida!");
        break;
     
   }

}