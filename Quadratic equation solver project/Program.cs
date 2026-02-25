using System;


    
    
        
        for (int vdi = 0; vdi < 3; vdi++)
        {
            
            Console.WriteLine($"Równanie {vdi + 1}");
            Console.Write("Podaj współczynnik a: ");
            double vdi_a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Podaj współczynnik b: ");
            double vdi_b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Podaj współczynnik c: ");
            double vdi_c = Convert.ToDouble(Console.ReadLine());

            
            if (vdi_a == 0)
            {
                
                double x = -vdi_c / vdi_b;
                Console.WriteLine($"To jest równanie liniowe. Jego rozwiązanie to x = {x}\n");
            }
            else
            {
               
                double delta = vdi_b * vdi_b - 4 * vdi_a * vdi_c;

                if (delta > 0)
                {
                    
                    double x1 = (-vdi_b + Math.Sqrt(delta)) / (2 * vdi_a);
                    double x2 = (-vdi_b - Math.Sqrt(delta)) / (2 * vdi_a);
                    Console.WriteLine($"Równanie kwadratowe. Pierwiastki: x1 = {x1}, x2 = {x2}\n");
                }
                else if (delta == 0)
                {
                    
                    double x = -vdi_b / (2 * vdi_a);
                    Console.WriteLine($"Równanie kwadratowe. Jeden podwójny pierwiastek: x = {x}\n");
                }
                else
                {
                    
                    Console.WriteLine("Równanie kwadratowe. Brak pierwiastków rzeczywistych (pierwiastki zespolone)\n");
                }
            }
        }
    





