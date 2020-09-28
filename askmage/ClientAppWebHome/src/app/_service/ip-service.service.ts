import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Address } from '../_models/address.model';
import { ConfigService } from './ConfigService';

@Injectable({
  providedIn: 'root'
})
export class IpServiceService {
  constructor(private http: HttpClient) { }
  url = 'http://localhost:55820';
  getIPAddress() {
    return this.http.get("http://ip-api.com/json");
  }

  EmployeeDevices_Create(ipinfo) {
    /*{"status":"success","country":"Vietnam","countryCode":"VN","region":"SG","regionName":"Ho Chi Minh","city":"Ho Chi Minh City","zip":"","lat":10.8142,"lon":106.6438,"timezone":"Asia/Ho_Chi_Minh","isp":"Viettel Corporation","org":"VIETEL","as":"AS7552 Viettel Group","query":"171.249.146.89"} */
    let data = [];
    console.log('test' + ipinfo);
    if (ipinfo != null) {
      data = [{
        IP: ipinfo.ip,
        Province: ipinfo.region,
        Country: ipinfo.country_name,
        ISP: ipinfo.asn.name
      }];
    } else{
      data = [{
        IP: '',
        Province: '',
        Country: '',
        ISP: ''
      }];
    }
    console.log('test');

    return this.http.post<any[]>(this.url + '/api/web/EmployeeDevices_Create', data);
  }

  EmmployeeAccess_UpdateTime(info) {
    /*{"status":"success","country":"Vietnam","countryCode":"VN","region":"SG","regionName":"Ho Chi Minh","city":"Ho Chi Minh City","zip":"","lat":10.8142,"lon":106.6438,"timezone":"Asia/Ho_Chi_Minh","isp":"Viettel Corporation","org":"VIETEL","as":"AS7552 Viettel Group","query":"171.249.146.89"} */
    let data = [{
      EmployeeId: info.EmployeeId,
      EAId: info.EAId
    }];
    return this.http.post<any[]>(this.url + '/api/web/EmmployeeAccess_UpdateTime', data);
  }
}
