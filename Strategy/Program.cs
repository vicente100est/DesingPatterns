using Strategy;

var context = new CContext(new CCar());
context.Run();
context.strategy1 = new CMoto();
context.Run();
context.strategy1 = new CBicycles();
context.Run();