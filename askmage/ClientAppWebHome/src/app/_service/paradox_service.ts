import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { ConfigService } from './ConfigService';

@Injectable({ providedIn: 'root' })
export class ParadoxService {
    constructor(private http: HttpClient) { }
    getparadox(employeeid) {
        return this.http.post(`${ConfigService.apiUrl}/api/web/getparadox`, {employeeid });
    }
}
