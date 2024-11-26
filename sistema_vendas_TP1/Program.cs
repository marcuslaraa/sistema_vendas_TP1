using sistema_vendas_TP1.model;
using sistema_vendas_TP1.Repository;

Client client = new Client("Marcus", 30, "42831413800"); 
Client client2 = new Client("Adriana", 56, "11111111111");

Product product = new Product("Samsung", "Galaxy S21", "Celular top de linha", 5000.00);
Product product2 = new Product("Apple", "Iphone 12", "Celular top de linha", 6000.00);

ProductRepository listProducts = new ProductRepository();

ClientRepository listClients = new ClientRepository();

listProducts.addProduct(product);
listProducts.addProduct(product2);

listClients.addClient(client);
listClients.addClient(client2);

Console.WriteLine(listClients.getAllClients());
Console.WriteLine(listClients.getClientByCode(client.Code));

Console.WriteLine(listProducts.getAllProducts());
Console.WriteLine(listProducts.getProductByCode(product.Code));

listClients.deleteClientByCode(client.Code);
listProducts.deleteProductByCode(product.Code);

Console.WriteLine(listClients.getAllClients());
Console.WriteLine(listProducts.getAllProducts());


