import { Observable } from 'rxjs/internal/Observable';
import {HttpClient, HttpHeaders } from '@angular/common/http';
import {Injectable } from '@angular/core';
import {environment} from 'src/environments/environment';
import {NhaHang} from '../models/nha-hang.model';
import {VaiTro} from '../models/vai-tro.model';

@Injectable({
    providedIn: 'root',
})
export class DataService {
    private REST_API_SERVER = environment.api;
    private httpOptions = {
        headers: new HttpHeaders({
            'Content-Type': 'applicatoin/json'
        }),
    };

    constructor(private HttpClient: HttpClient){}

    public getAllNhaHang(): Observable<NhaHang[]> {
        const url = `${this.REST_API_SERVER}/NhaHang`;
        return this.HttpClient.get<NhaHang[]>(url, this.httpOptions);
    }

    public postNhaHang(payload: NhaHang): Observable<any> {
        const url = `${this.REST_API_SERVER}/NhaHang`;
        return this.HttpClient.post<NhaHang>(url, payload, this.httpOptions);
    }

    public getAllVaiTro(): Observable<VaiTro[]> {
        const url = `${this.REST_API_SERVER}/VaiTro`;
        return this.HttpClient.get<VaiTro[]>(url, this.httpOptions);
    }
}