using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Preguntas : MonoBehaviour
{

    ArrayList preguntas = new ArrayList();
    ArrayList respuestaUno = new ArrayList();
    ArrayList respuestaDos = new ArrayList();
    ArrayList respuestaTres = new ArrayList();
    ArrayList respuesta = new ArrayList();

    // Start is called before the first frame update
    void Start()
    {
        
        ingresoPreguntas();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void ingresoPreguntas()
    {


        preguntas.Add("¿Qué son los tepuyes?");
        respuestaUno.Add("Grandes montañas de roca.");
        respuestaDos.Add("Animales pequeñitos.");
        respuestaTres.Add("Semillas que caen de árboles gigantescos.");
        respuesta.Add("Grandes montañas de roca.");

        preguntas.Add("¿Qué es un pictograma?");
        respuestaUno.Add("Símbolos de una raza guerrera.");
        respuestaDos.Add("Signos que a través de un símbolo representan pensamientos o ideas.");
        respuestaTres.Add("Dibujos que relatan la historia de una civilización.");
        respuesta.Add("Signos que a través de un símbolo representan pensamientos o ideas.");

        preguntas.Add("¿Cuál es la edad de los pictogramas hallados en los tepuyes amazónicos de Colombia?");
        respuestaUno.Add("90.000 – 100.000 años.");
        respuestaDos.Add("15 – 20 millones de años.");
        respuestaTres.Add("15.000 – 20.000 años.");
        respuesta.Add("15.000 – 20.000 años.");

        preguntas.Add("¿Porqué las rocas de la serranía del Chiribiquete son consideradas patrimonio de la humanidad?");
        respuestaUno.Add("Porque en ellas hay gran variedad de plantas y aves.");
        respuestaDos.Add("Porque se han encontrado indicios de posiblemente la primera civilización en todo el mundo.");
        respuestaTres.Add("Por la reserva geológica y por ser las rocas sedimentarias más antiguas de la región.");
        respuesta.Add("Por la reserva geológica y por ser las rocas sedimentarias más antiguas de la región.");

        preguntas.Add("¿Porqué el personaje principal del juego Golem es una roca?");
        respuestaUno.Add("Hace honor a las rocas de la serranía del Chiribiquete.");
        respuestaDos.Add("Por su composición semejante a las rocas.");
        respuestaTres.Add("Porque resalta la importancia de cuidar el patrimonio de la humanidad.");
        respuesta.Add("Hace honor a las rocas de la serranía del Chiribiquete.");

        preguntas.Add("¿Cuáles son las 3 eras principales de la vida?");
        respuestaUno.Add("Gondwana, Laurasia, Pangea.");
        respuestaDos.Add("Paleozoica, Mesozoica y Cenozoica.");
        respuestaTres.Add("Naces, vives y mueres.");
        respuesta.Add("Paleozoica, Mesozoica y Cenozoica.");

        preguntas.Add("¿Es cierto que Colombia gran parte de su desarrollo estuvo bajo el agua?");
        respuestaUno.Add("No.");
        respuestaDos.Add("No sé.");
        respuestaTres.Add("Si.");
        respuesta.Add("Si.");

        preguntas.Add("Colombia hizo parte del super continente _____:");
        respuestaUno.Add("Laurasia.");
        respuestaDos.Add("Gondwana.");
        respuestaTres.Add("Amasia.");
        respuesta.Add("Gondwana.");

        preguntas.Add("¿Durante qué eras Colombia se encontró sumergida bajo el agua?");
        respuestaUno.Add("Paleozoica y Cenozoica.");
        respuestaDos.Add("Cenozoica y Mesozoica.");
        respuestaTres.Add("Paleozoica y Mesozoica.");
        respuesta.Add("Paleozoica y Mesozoica.");

        preguntas.Add("¿En qué época Colombia comenzó su desarrollo geológico a lo que conocemos ahora como Colombia?");
        respuestaUno.Add("Paleozoica.");
        respuestaDos.Add("Mesozoica.");
        respuestaTres.Add("Cenozoica.");
        respuesta.Add("Cenozoica.");

        preguntas.Add("¿Porqué Colombia es tan rica en flora y fauna?");
        respuestaUno.Add("Porque estuvo gran tiempo bajo el agua.");
        respuestaDos.Add("Porque influyeron los dinosaurios en su desarrollo.");
        respuestaTres.Add("Porque tenemos gran diversidad en animales y plantas.");
        respuesta.Add("Porque estuvo gran tiempo bajo el agua.");

        preguntas.Add("¿Es posible considerar a Colombia como uno de los territorios que tuvo más dinosaurios durante el desarrollo de la historia?");
        respuestaUno.Add("No.");
        respuestaDos.Add("Absolutamente.");
        respuestaTres.Add("Si");
        respuesta.Add("Absolutamente.");

        preguntas.Add("Las aves son parientes de los _______:");
        respuestaUno.Add("Reptiles voladores.");
        respuestaDos.Add("Aves raras que volaban.");
        respuestaTres.Add("Dinosaurios voladores.");
        respuesta.Add("Reptiles voladores.");

        preguntas.Add("¿Cuál era el tamaño aproximado de la Titanoboa?");
        respuestaUno.Add("20 metros.");
        respuestaDos.Add("13 metros.");
        respuestaTres.Add("13 centímetros.");
        respuesta.Add("13 metros.");

        preguntas.Add("¿A qué animal hacen alusión las serpientes del tablero del juego?");
        respuestaUno.Add("La cobra.");
        respuestaDos.Add("La anaconda.");
        respuestaTres.Add("La Titanoboa.");
        respuesta.Add("La Titanoboa.");

        preguntas.Add("El Ichthyosaurio es familiar del _______:");
        respuestaUno.Add("Reptil acuático.");
        respuestaDos.Add("Cocodrilos.");
        respuestaTres.Add("El megalodón.");
        respuesta.Add("Reptil acuático.");

        preguntas.Add("Colombia ocupa el primer lugar en…");
        respuestaUno.Add("Variedad de orquídeas y aves.");
        respuestaDos.Add("Variedad de mariposas y orquídeas.");
        respuestaTres.Add("Variedad de aves y mariposas.");
        respuesta.Add("Variedad de orquídeas y aves.");

        preguntas.Add("Colombia ocupa el segundo lugar en…");
        respuestaUno.Add("Variedad de orquídeas y aves.");
        respuestaDos.Add("Variedad de anfibios, mariposas y plantas.");
        respuestaTres.Add("Variedad de anfibios, mariposas y orquídeas.");
        respuesta.Add("Variedad de anfibios, mariposas y plantas.");

        preguntas.Add("Colombia ocupa el tercer lugar en…");
        respuestaUno.Add("Variedad de aves.");
        respuestaDos.Add("Variedad de mariposas.");
        respuestaTres.Add("Variedad de primates.");
        respuesta.Add("Variedad de primates.");



    }



    // getter de los arrayList
    public ArrayList getPreguntas()
    {
        return this.preguntas;
    }
    public ArrayList getRespuestaUno()
    {
        return this.respuestaUno;
    }
    public ArrayList getRespuestaDos()
    {
        return this.respuestaDos;
    }
    public ArrayList getRespuestaTres()
    {
        return this.respuestaTres;
    }
    public ArrayList getRespuesta()
    {
        return this.respuesta;
    }


}
