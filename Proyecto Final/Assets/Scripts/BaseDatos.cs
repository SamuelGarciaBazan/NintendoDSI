using UnityEngine;
using System.Collections.Generic;
using Lab5b_namespace;

namespace Lab5c_namespace
{
    public class BaseDatos
    {
        public static List<Individuo> getData()
        {
            List<Individuo> datos = new List<Individuo>();

            Individuo astra = new Individuo(
                "controlador",
                "astra",
<<<<<<< Updated upstream
                "La agente ghanesa Astra canaliza las energías del cosmos para remodelar los campos de batalla a su antojo. Con pleno dominio de su forma astral y un talento para una profunda previsión estratégica, siempre está eones por delante del próximo movimiento de su enemigo.",
                ""
=======
                "La agente ghanesa Astra canaliza las energías " +
                "del cosmos para remodelar los campos de batalla " +
                "a su antojo. Con pleno dominio de su forma astral " +
                "y un talento para una profunda previsión estratégica," +
                " siempre está eones por delante del próximo movimiento de su enemigo.",
                "controlador",
                "descripcion controlador"
>>>>>>> Stashed changes
            );

            Individuo breach = new Individuo(
                "iniciador",
                "breach",
<<<<<<< Updated upstream
                "Breach, el sueco biónico, lanza poderosas ráfagas cinéticas para abrirse paso a la fuerza a través del territorio enemigo. El daño y la interrupción que inflige garantizarán que ninguna pelea sea justa.",
                ""
=======
                "Breach, el sueco biónico, lanza poderosas ráfagas cinéticas " +
                "para abrirse paso a la fuerza a través del territorio enemigo." +
                " El daño y la interrupción que inflige garantizarán que ninguna pelea sea justa.",
                "iniciador",
                "descripcion iniciador"
>>>>>>> Stashed changes
            );

            Individuo brimstome = new Individuo(
                "controlador",
                "brismtome",
<<<<<<< Updated upstream
                "Proveniente de Estados Unidos, Brimstone proporciona una constante ventaja para su equipo con su arsenal orbital. Su habilidad otorga información de forma precisa y a distancia, lo que lo hace un comandante sin igual en el campo.",
                ""
=======
                "Proveniente de Estados Unidos, Brimstone proporciona una" +
                " constante ventaja para su equipo con su arsenal orbital." +
                " Su habilidad otorga información de forma precisa y a distancia," +
                " lo que lo hace un comandante sin igual en el campo.",
                "controlador",
                "descripcion controlador"
>>>>>>> Stashed changes
            );

            Individuo chamber = new Individuo(
                "centinela",
                "chamber",
<<<<<<< Updated upstream
                "Bien vestido y bien armado, el diseñador de armas francés Chamber repele agresores con una precisión mortal. Aprovecha su arsenal personalizado para mantener a los enemigos a raya y eliminarlos desde lejos. Siempre cuenta con la contingencia perfecta para cada plan.",
                ""
=======
                "Bien vestido y bien armado, el diseñador de armas francés " +
                "Chamber repele agresores con una precisión mortal. Aprovecha" +
                " su arsenal personalizado para mantener a los enemigos a raya" +
                " y eliminarlos desde lejos. Siempre cuenta con la contingencia " +
                "perfecta para cada plan.",
                "centinela",
                "descripcion centinela"
>>>>>>> Stashed changes
            );

            Individuo clove = new Individuo(
                "controlador",
                "clove",
<<<<<<< Updated upstream
                "Clove llega desde Escocia buscando pleitos y sus travesuras no paran ni en el calor de la batalla, ni en el frío de la muerte. Con juventud e inmortalidad, confunde a los enemigos incluso desde el más allá, porque saben que en cualquier momento puede regresar al mundo de los vivos.",
                ""
=======
                "Clove llega desde Escocia buscando pleitos y sus travesuras " +
                "no paran ni en el calor de la batalla, ni en el frío de la muerte. " +
                "Con juventud e inmortalidad, confunde a los enemigos incluso desde " +
                "el más allá, porque saben que en cualquier momento puede regresar al " +
                "mundo de los vivos.",
                "controlador",
                "descripcion controlador"
>>>>>>> Stashed changes

            );


            Individuo cypher = new Individuo(
                "centinela",
                "cypher",
<<<<<<< Updated upstream
                "Cypher, el agente de información marroquí, es un sistema de vigilancia de un solo hombre que puede monitorear todos los movimientos de sus enemigos. No hay secreto que no descubra ni maniobra que no detecte. Cypher siempre está vigilando.",
                ""
=======
                "Cypher, el agente de información marroquí, es un sistema de " +
                "vigilancia de un solo hombre que puede monitorear todos los" +
                " movimientos de sus enemigos. No hay secreto que no descubra" +
                " ni maniobra que no detecte. Cypher siempre está vigilando.",
                "centinela",
                "descripcion centinela"
>>>>>>> Stashed changes
            );


            Individuo deadlock = new Individuo(
                "centinela",
                "deadlock",
<<<<<<< Updated upstream
                "La agente noruega Deadlock despliega una variedad de nanocables de alta tecnología para asegurar el campo de batalla, incluso en los asaltos más letales. Nadie escapa de su ojo vigilante ni sobrevive a su ferocidad inquebrantable.",
                ""
=======
                "La agente noruega Deadlock despliega una variedad de nanocables " +
                "de alta tecnología para asegurar el campo de batalla, incluso en" +
                " los asaltos más letales. Nadie escapa de su ojo vigilante ni " +
                "sobrevive a su ferocidad inquebrantable.",
                "centinela",
                "descripcion centinela"
>>>>>>> Stashed changes
            );


            Individuo fade = new Individuo(
                "iniciador",
                "fade",
<<<<<<< Updated upstream
                "Fade, la cazarrecompensas turca, desata el poder de las pesadillas para apoderarse de los secretos del enemigo. En armonía con el terror puro, acecha a sus objetivos y revela sus miedos más profundos antes de aplastarlos en la oscuridad.",
                ""
=======
                "Fade, la cazarrecompensas turca, desata el poder de las pesadillas" +
                " para apoderarse de los secretos del enemigo. En armonía con el" +
                " terror puro, acecha a sus objetivos y revela sus miedos más profundos " +
                "antes de aplastarlos en la oscuridad.",
                "iniciador",
                "descripcion iniciador"
>>>>>>> Stashed changes
            );


            Individuo gekko = new Individuo(
                "iniciador",
                "gekko",
<<<<<<< Updated upstream
                "Gekko, el nativo de Los Ángeles, lidera un grupo de criaturas revoltosas y son como uña y mugre. Sus amiguitos avanzan a toda velocidad, dispersando a los enemigos, y Gekko los persigue para reagruparlos y lanzarlos de nuevo.",
                ""
=======
                "Gekko, el nativo de Los Ángeles, lidera un grupo de criaturas " +
                "revoltosas y son como uña y mugre. Sus amiguitos avanzan a toda " +
                "velocidad, dispersando a los enemigos, y Gekko los persigue para " +
                "reagruparlos y lanzarlos de nuevo.",
                "iniciador",
                "descripcion iniciador"
>>>>>>> Stashed changes
            );


            Individuo harbor = new Individuo(
                "controlador",
                "harbor",
<<<<<<< Updated upstream
                "Originario de las costas de la India, Harbor arrasa el campo de batalla utilizando tecnología ancestral que controla el agua. Desata corrientes furiosas y olas aplastantes para escudar aliados y apalear oponentes.",
                ""
=======
                "Originario de las costas de la India, Harbor arrasa el" +
                " campo de batalla utilizando tecnología ancestral que " +
                "controla el agua. Desata corrientes furiosas y olas " +
                "aplastantes para escudar aliados y apalear oponentes.",
                "controlador",
                "descripcion controlador"
>>>>>>> Stashed changes
            );


            Individuo iso = new Individuo(
                "duelista",
                "iso",
<<<<<<< Updated upstream
                "El agente chino Iso es un neutralizador a sueldo que entra en estado de fluidez para desmantelar a sus oponentes. Reconfigura la energía ambiental para convertirla en una protección a prueba de balas y avanza con determinación hacia su próximo duelo a muerte.",
                ""
=======
                "El agente chino Iso es un neutralizador a sueldo que entra en" +
                " estado de fluidez para desmantelar a sus oponentes. Reconfigura" +
                " la energía ambiental para convertirla en una protección a prueba " +
                "de balas y avanza con determinación hacia su próximo duelo a muerte.",
                "duelista",
                "descripcion duelista"
>>>>>>> Stashed changes
            );


            Individuo jett = new Individuo(
                "duelista",
                "jett",
<<<<<<< Updated upstream
                "Proviene de Corea del Sur. El ágil y evasivo estilo de pelea de Jett le permite enfrentarse a riesgos que otros no pueden. Es imparable en todos los enfrentamientos y acaba con sus enemigos antes de que sepan qué los atacó.",
                ""
=======
                "Proviene de Corea del Sur. El ágil y evasivo estilo de pelea de " +
                "Jett le permite enfrentarse a riesgos que otros no pueden. Es " +
                "imparable en todos los enfrentamientos y acaba con sus enemigos " +
                "antes de que sepan qué los atacó.",
                "duelista",
                "descripcion duelista"
>>>>>>> Stashed changes
            );


            Individuo kayo = new Individuo(
                "iniciador",
                "kayo",
<<<<<<< Updated upstream
                "KAY/O es una máquina de guerra construida para un único propósito: neutralizar radiantes. Su poder para suprimir las habilidades del enemigo anula la capacidad de sus oponentes para contraatacar, lo que les asegura a él y a sus aliados la ventaja definitiva.",
                ""
=======
                "KAY/O es una máquina de guerra construida para un único " +
                "propósito: neutralizar radiantes. Su poder para suprimir " +
                "las habilidades del enemigo anula la capacidad de sus " +
                "oponentes para contraatacar, lo que les asegura a él y a " +
                "sus aliados la ventaja definitiva.",
                "iniciador",
                "descripcion iniciador"
>>>>>>> Stashed changes
            );


            Individuo killjoy = new Individuo(
                "centinela",
                "killjoy",
<<<<<<< Updated upstream
                "La prodigio alemana Killjoy asegura fácilmente los puntos estratégicos del campo de batalla con su arsenal de inventos. Si el daño que inflige no detiene a sus enemigos, las debilitaciones de sus robots la ayudarán a aniquilarlos.",
                ""
=======
                "La prodigio alemana Killjoy asegura fácilmente los puntos " +
                "estratégicos del campo de batalla con su arsenal de inventos. " +
                "Si el daño que inflige no detiene a sus enemigos, las " +
                "debilitaciones de sus robots la ayudarán a aniquilarlos.",
                "centinela",
                "descripcion centinela"
>>>>>>> Stashed changes
            );


            Individuo neon = new Individuo(
                "duelista",
                "neon",
<<<<<<< Updated upstream
                "La agente filipina, Neon, avanza a velocidades impactantes, descargando ráfagas de energía bioeléctrica tan rápido como su cuerpo la genera. Se adelanta velozmente a sus enemigos para atraparlos desprevenidos y luego los fulmina más rápido que un rayo.",
                ""
=======
                "La agente filipina, Neon, avanza a velocidades impactantes, " +
                "descargando ráfagas de energía bioeléctrica tan rápido como " +
                "su cuerpo la genera. Se adelanta velozmente a sus enemigos " +
                "para atraparlos desprevenidos y luego los fulmina más rápido que un rayo.",
                "duelista",
                "descripcion duelista"
>>>>>>> Stashed changes
            );


            Individuo omen = new Individuo(
                "controlador",
                "omen",
<<<<<<< Updated upstream
                "Un espectro de la memoria, Omen caza entre las sombras, ciega a los enemigos, se transporta a través del campo de batalla y deja que la paranoia los invada mientras intentan descubrir dónde atacará.",
                ""
=======
                "Un espectro de la memoria, Omen caza entre las sombras, ciega " +
                "a los enemigos, se transporta a través del campo de batalla y " +
                "deja que la paranoia los invada mientras intentan descubrir dónde atacará.",
                "controlador",
                "descripcion controlador"
>>>>>>> Stashed changes
            );


            Individuo phoenix = new Individuo(
                "duelista",
                "phoenix",
<<<<<<< Updated upstream
                "Proviene del Reino Unido. El poder estelar de Phoenix se manifiesta en su estilo de combate al incendiar el campo de batalla con sus granadas aturdidoras y cegadoras. Sin importar si cuenta con apoyo o no, participará en la batalla bajo sus propios términos.",
                ""
=======
                "Proviene del Reino Unido. El poder estelar de Phoenix se manifiesta " +
                "en su estilo de combate al incendiar el campo de batalla con sus " +
                "granadas aturdidoras y cegadoras. Sin importar si cuenta con apoyo " +
                "o no, participará en la batalla bajo sus propios términos.",
                "duelistaq",
                "descripcion duelista"
>>>>>>> Stashed changes
            );


            Individuo raze = new Individuo(
                "duelista",
                "raze",
<<<<<<< Updated upstream
                "Raze llega de Brasil con su explosiva personalidad y sus grandes armas. Gracias a su contundente estilo de juego, es muy buena para separar a los enemigos atrincherados y para despejar espacios estrechos con una gran cantidad de explosiones.",
                ""
=======
                "Raze llega de Brasil con su explosiva personalidad y sus grandes " +
                "armas. Gracias a su contundente estilo de juego, es muy buena para " +
                "separar a los enemigos atrincherados y para despejar espacios estrechos " +
                "con una gran cantidad de explosiones.",
                "duelista",
                "descripcion duelista"
>>>>>>> Stashed changes
            );


            Individuo reyna = new Individuo(
                "duelista",
                "reyna",
<<<<<<< Updated upstream
                "Desde el corazón de México, Reyna llega para dominar los duelos uno contra uno y cada asesinato que realiza aumenta su poder. Su letalidad solo está limitada por tu destreza al usarla, por lo que su eficacia dependerá mucho de ello.",
                ""
=======
                "Desde el corazón de México, Reyna llega para dominar los duelos " +
                "uno contra uno y cada asesinato que realiza aumenta su poder. " +
                "Su letalidad solo está limitada por tu destreza al usarla, por " +
                "lo que su eficacia dependerá mucho de ello.",
                "duelista",
                "descripcion duelista"
>>>>>>> Stashed changes
            );


            Individuo sage = new Individuo(
                "centinela",
                "sage",
<<<<<<< Updated upstream
                "El bastión de China. Sage proporciona seguridad para sí misma y para su equipo en cualquier lugar. Gracias a su capacidad de revivir a sus compañeros caídos y evitar ataques agresivos, les da un lugar de protección en medio de la caótica pelea.",
                ""
=======
                "El bastión de China. Sage proporciona seguridad para sí misma y " +
                "para su equipo en cualquier lugar. Gracias a su capacidad de revivir " +
                "a sus compañeros caídos y evitar ataques agresivos, les da un lugar " +
                "de protección en medio de la caótica pelea.",
                "centinela",
                "descripcion centinela"
>>>>>>> Stashed changes
            );

            datos.Add(astra);
            datos.Add(breach);
            datos.Add(brimstome);
            datos.Add(chamber);
            datos.Add(clove);
            datos.Add(cypher);
            datos.Add(deadlock);
            datos.Add(fade);
            datos.Add(gekko);
            datos.Add(harbor);
            datos.Add(iso);
            datos.Add(jett);
            datos.Add(kayo);
            datos.Add(killjoy);
            datos.Add(neon);
            datos.Add(omen);
            datos.Add(phoenix);
            datos.Add(raze);
            datos.Add(reyna);
            datos.Add(sage);

            return datos;
        }
    }
}
