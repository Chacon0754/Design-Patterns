public class Main {
    public static void main(String[] args) {
        Handler handlerA = new ConcreteHandlerA();
        Handler handlerB = new ConcreteHandlerB();
        Handler handlerC = new ConcreteHandlerC();

        handlerA.setNext(handlerB);
        handlerB.setNext(handlerC);

        System.err.println("Testing Concrete Handler Chain");
        handlerA.handleRequest("TypeB");

        Handler level1 = new SupportLevel1();
        Handler level2 = new SupportLevel2();
        Handler level3 = new SupportLevel3();

        level1.setNext(level2);
        level2.setNext(level3);


        System.err.println("\nTesting support levels chain: ");
        level1.handleRequest("Level3");
    }
}
