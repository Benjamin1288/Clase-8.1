void matriz()
{
    string[] nombre = new string[]
    {
    "Anderson","Brandon","Yeimi","Fatima","Vivian"
    };

    //for (int i=0;i<nombre.Length;++)
    //{
    //    Console.WriteLine("Elemento:"+nombre[i]);
    //}
    foreach (string n in nombre)
    {
        Console.WriteLine("nombre: " + n);
    }
    int[] notas = new int[]
    {
        50,90,85,73,95
    };
    int promedio = 0;
    foreach (int n in notas)
    {
        promedio = promedio + n;
    }
    promedio = promedio / notas.Length;
    Console.WriteLine("El promedio es igual a: " + promedio);
    int mayor = 0, d = 0, menor = 100, d2 = 0;
    int nose = -1, nose2 = -1;
    for (int i = 0; i < notas.Length; i++)
    {
        if (notas[i] > mayor)
        {
            mayor = notas[i];
            nose = d;
        }
        d++;
    }
    for (int i = 0; i < notas.Length; i++)
    {
        if (notas[i] < menor)
        {
            menor = notas[i];
            nose2 = d2;
        }
        d2++;
    }
    Console.WriteLine("-------------------------------------------------------------");
    for (int i = 0; i < nombre.Length; i++)
    {
        Console.WriteLine(nombre[i] + ": " + notas[i]);
    }
    Console.WriteLine("-------------------------------------------------------------");
    Console.WriteLine("La nota mas alta es " + mayor + " que le pertenece a " + nombre[nose]);
    Console.WriteLine("La nota menor es " + menor + " que le pertenece a " + nombre[nose2]);
    Console.WriteLine("-------------------------------------------------------------");
}
matriz();
