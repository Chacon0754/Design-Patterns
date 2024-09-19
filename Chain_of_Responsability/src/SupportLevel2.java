public class SupportLevel2 extends Handler {
    @Override
    public void handleRequest(String request) {
        if (request.equalsIgnoreCase("Level2")) {
            System.out.println("Support Level 2 handled the request. ");
        } else if (next != null) {
            next.handleRequest(request);
        } else {
            System.out.println("Request was not handled");
        }
    }
}
