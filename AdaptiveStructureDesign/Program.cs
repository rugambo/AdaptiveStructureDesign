// See https://aka.ms/new-console-template for more information
using AdaptiveStructureDesign;

//Create an instance of the EtherPayment class which does not have a reference to interface 
EtherPayment etherPayment = new EtherPayment();

//Call transaction to ensure that the EtherPayment class does in fact conduct a transaction
etherPayment.TransactEther(150.25d);

//Create an instance of EtherAdapter which does has interface, which is a wonky way to do inheritance for C#
EtherAdapter etherAdapter = new EtherAdapter(etherPayment);

//Call the interface pay function to make that interface is getting called 
etherAdapter.Pay(200.55d);

//Create a new class that uses everything already created to make sure that the interface is still working
Store store = new Store();
store.Transaction(etherAdapter, 29.99);