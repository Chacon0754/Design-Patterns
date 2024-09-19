public class SupportLevel3 extends Handler {
    @Override
    public void handleRequest(String request) {
        if (request.equalsIgnoreCase("Level3")) {
            System.out.println("Support Level 3 handled the request. ");
        } else {
            System.out.println("Request could not be handled.");
        }
    }
}
