class Request {

    response = undefined;
    fulfilled = false;

    constructor(method, uri, version, message){
        this.method = method;
        this.uri = uri;
        this.version = version;
        this.message = message;
    }
}
