string[] proteinas = { "Peito de Frango", "Filé de Peixe", "Contra-Filé", "Carne Magra", "Ovos" };
        string[] carbo = { "Batata", "Arroz", "Feijão", "Macarrão", "Mandioca", "Mandioquinha", "Milho" };
        string[] legumes = { "Brócolis", "Alface", "Tomate", "Cenoura" };

        Console.WriteLine("Escolha se quer:\n1) Aleatório\n2) De escolha");
        string decisao = Console.ReadLine();
        
        switch (decisao)
        {
            case "1":
                Console.WriteLine("Modo escolhido: Aleatório");
                Random random = new Random();
                string pratoProteina = proteinas[random.Next(proteinas.Length)];
                string pratoCarbo = carbo[random.Next(carbo.Length)];
                string pratoLegume = legumes[random.Next(legumes.Length)];
                Console.WriteLine($"Seu prato montado aleatoriamente é: {pratoCarbo} com {pratoProteina} e {pratoLegume}");
                break;

            case "2":
                Console.WriteLine("Modo escolhido: De escolha");
                Console.WriteLine("1) Prato Arroz e macarrão");
                Console.WriteLine("2) Prato Arroz e Carne Magra");
                Console.WriteLine("3) Prato Arroz, Cenoura e Filé de Peixe");
                Console.WriteLine("4) Prato Arroz e Feijão");
                Console.WriteLine("5) Prato Macarrão, Mandioquinha e Peito de Frango");
                Console.Write("Escolha um prato (1-5): ");
                
                string escolha = Console.ReadLine();
                switch (escolha)
                {
                    case "1":
                        Console.WriteLine("Você escolheu: Prato Arroz e macarrão");
                        break;
                    case "2":
                        Console.WriteLine("Você escolheu: Prato Arroz e Carne Magra");
                        break;
                    case "3":
                        Console.WriteLine("Você escolheu: Prato Arroz, Cenoura e Filé de Peixe");
                        break;
                    case "4":
                        Console.WriteLine("Você escolheu: Prato Arroz e Feijão");
                        break;
                    case "5":
                        Console.WriteLine("Você escolheu: Prato Macarrão, Mandioquinha e Peito de Frango");
                        break;
                    default:
                        Console.WriteLine("Escolha inválida. Por favor, selecione um número entre 1 e 5.");
                        break;
                }
                break;

            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
