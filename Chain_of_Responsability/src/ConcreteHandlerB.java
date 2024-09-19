public class ConcreteHandlerB extends Handler {
    
    @Override
    public void handleRequest(String request) {
        if (canHandle(request)) {
            System.out.println("ConcreteHandlerB processed the request");
        } else if (next != null) {
            next.handleRequest(request);
        } else{
            System.out.println("Request was nos handled.");
        }
    }

    private boolean canHandle(String request) {
        return request.equals("TypeB");
    }
}
