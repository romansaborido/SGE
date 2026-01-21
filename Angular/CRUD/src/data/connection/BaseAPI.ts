
@injectable()
export class BaseAPI {

    private readonly url: string = "https://ui20251201131951-bgbgb9aqgcd7ggh6.italynorth-01.azurewebsites.net/api/"

    public getUrl(endpoint: string): string {
        const url = new URL(endpoint, this.url)
        return url.toString()
    }

    public getDefaultHeaders(): HeadersInit {
        return {
            "Content-Type": "application/json"
        }
    }
}