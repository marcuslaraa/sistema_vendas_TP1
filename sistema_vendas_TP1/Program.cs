using sistema_vendas_TP1.model;
using sistema_vendas_TP1.Repository;

Client client = new Client("Marcus", 30, "42831413800"); 
Client client2 = new Client("Adriana", 56, "11111111111");

ClientRepository listClients = new ClientRepository();

listClients.addClient(client);
listClients.addClient(client2);

Console.WriteLine(listClients.getAllClients());
Console.WriteLine(listClients.getClientByCode(client.Code));

listClients.deleteClientByCode(client.Code);

Console.WriteLine(listClients.getAllClients());


