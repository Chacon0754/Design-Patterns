public class ConcreteHandlerA extends Handler {

    @Override
    public void handleRequest(String request) {
        if (canHandle(request)) {
            System.out.println("ConcreteHandlerA processed the request");
        } else if (next != null) {
            next.handleRequest(request);
        } else {
            System.out.println("Request was not handled");
        }
    }
    
    private boolean canHandle(String request) {
        return request.equalsIgnoreCase("TypeA");
    }
}
