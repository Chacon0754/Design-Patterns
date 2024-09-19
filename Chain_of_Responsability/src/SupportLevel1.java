public class SupportLevel1 extends Handler {
    @Override
    public void handleRequest(String request) {
        if (request.equalsIgnoreCase("Level1")) {
            System.out.println("Support Level 1 handled the request.");
        } else if (next != null) {
            next.handleRequest(request);
        } else {
            System.out.println("Request was not handled.");
        }
    }
}
