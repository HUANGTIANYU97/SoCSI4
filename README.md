# **Let's go biking**

## **Introduction**

Monitoring est un IWS qui fournit des données de surveillance.
WcfServiceLibrary est un IWS pour JCDecaux.
MapService est un IWS pour Google Map.
GUI est une application WinForm  qui fournit clients un itinéraire de la station Velib du point de départ à la destination basées sur JCDeaux et Google Map.
MonitorForm est une application WinForm qui peut afficher des informations de surveillance de la forme du texte et la forme graphique.

## **Mode de fonctionnement**

Tout d'abord, démarrez Monitoring, puis démarrez WcfServiceLibrary et enfin démarrez MapService.
Ensuite, vous pouvez demarrer GUI (utilisateur normal) et MonitorForm (utilisateur moniteur).

Exemples:

Rouen
Musée des Beaux-Arts de Rouen
Hospital Center University De Rouen

Lyon
Musée des Beaux-Arts de Lyon
Lyon Part-Dieu Commercial Shopping Centre

Toulouse
Muséum de Toulouse
Université Toulouse 1 Capitole

### **JCDecaux Service**

- GetContracts()    Fournir des informations sur toutes les villes de JCDecaux
- GetCityStations(string cityStations)    Fournir des informations de toutes les stations de la ville correspondante

Un cache statique est ajouté pour stocker les informations des sations, réduisant les communication entre JCDecaux et IWS.


### **Google Map Service**

- GetLocation(string address)    Obtenir la position de l'adresse spécifiée
- FindNearestStationPosition(string address, string contract)    Trouver la station la plus proche de l'adresse du départ dans la ville correspondante
- FindNearestDestinationStationPosition(string address, string contract)    Trouver la station la plus proche de l'adresse de la destination dans la ville correspondante	
- FindRoute(string contract, string startPoint, string endPoint)    Trouver un itinéraire du départ à la station et à la destination dans la ville correspondante

### **Monitor Service**

Fournir deux types de service: 

Obtenir des informations de surveillance
- GetNumberClients(int period)
- GetNumberClientRequests(int period)
- GetNumberRequestsVelib(int period)
- GetNumberRequestsGoogle(int period)
- GetCurrentAverageDelay()

Mettre à jour les informations de surveillance
- UpdateNumberClients(int period)
- UpdateNumberClientRequests(int period)
- UpdateNumberRequestsVelib(int period)
- UpdateNumberRequestsGoogle(int period)
- UpdateCurrentAverageDelay()

Afin de gérer les informations de surveillance, les données de surveillance sont tous statiques.
