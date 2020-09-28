export class Address {
    status: string;
    country: string;
    countryCode: string;
    region: string;
    regionName: string;
    city: string;
    zip: string;
    lat: number;
    lon: number;
    timezone: string;
    isp: string;
    org: string;
    as: string;
    query: string;

    constructor() {
        this.status = '';
        this.country = '';
        this.countryCode = '';
        this.region = '';
        this.regionName = '';
        this.city = '';
        this.zip = '';
        this.lat = 0;
        this.lon = 0;
        this.timezone = '';
        this.isp = '';
        this.org = '';
        this.as = '';
        this.query = '';
    }
}