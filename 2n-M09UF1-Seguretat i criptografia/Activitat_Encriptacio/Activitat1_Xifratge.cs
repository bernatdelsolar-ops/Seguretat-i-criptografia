/// Esta clase contiene funciones para encriptar/desencriptar
/// El ser estática no es necesario instanciar un objeto para 
/// usar las funciones Encriptar y DesEncriptar

public static class Seguridad
{

/// Encripta una cadena
public static string Encriptar(this string _cadenaAencriptar)
{
string result = string.Empty;
byte[] encryted = System.Text.Encoding.Unicode.GetBytes(_cadenaAencriptar);
result = Convert.ToBase64String(encryted);
return result;
}

/// Esta función desencripta la cadena que le envíamos en el parámentro de entrada.
public static string DesEncriptar(this string _cadenaAdesencriptar)
{
string result = string.Empty;
byte[] decryted = Convert.FromBase64String(_cadenaAdesencriptar);
//result = System.Text.Encoding.Unicode.GetString(decryted, 0, decryted.ToArray().Length);
result = System.Text.Encoding.Unicode.GetString(decryted);
return result;
}
}



en el siguiente código podemos ver cómo usar la clase anterior:

protected void btnInicio_Click(object sender, EventArgs e)
        {     
//encriptamos la cadena inicial       
            txtcadenaencriptada.Text = Seguridad.Encriptar(txtcadenainicial.Text);
//ahora desencriptamos
            txtcadenafinal.Text = Seguridad.DesEncriptar(txtcadenaencriptada.Text);
//Vereis que despues de estas instrucciones txtcadenainial y txtcadenafinal contienen lo mismo.
