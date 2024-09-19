public class ConcreteHandlerC extends Handler {
    @Override
    public void handleRequest(String request) {
        if (canHandle(request)) {
            System.out.println("ConcreteHandlerC processed the request. ");
        } else if (next != null) {
            next.handleRequest(request);
        } else {
            System.out.println("Request was not handled. ");
        }
    }
    
    private boolean canHandle(String request) {
        return request.equalsIgnoreCase("TypeC");
    }
}
