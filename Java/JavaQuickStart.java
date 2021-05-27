HttpRequest request = HttpRequest.newBuilder()
		.uri(URI.create("https://document-scanner.p.rapidapi.com/DetectDocument"))
		.header("x-rapidapi-key", "API KEY")
		.header("x-rapidapi-host", "document-scanner.p.rapidapi.com")
		.method("POST", HttpRequest.BodyPublishers.noBody())
		.build();
HttpResponse<String> response = HttpClient.newHttpClient().send(request, HttpResponse.BodyHandlers.ofString());
System.out.println(response.body());
