import { environment } from './../../../environments/environment';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/Observable';
import 'rxjs/Rx';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';

@Injectable()
export class HttpService {
  public ROOTPATH: string = environment.apiUrl;

  constructor(private http: HttpClient) {
  }

  post(url: string, element?: any, options?: any): Observable<any> {
    options = {...options};
    return this.http.post(this.ROOTPATH + url, element, options)
      .catch(this.handleErrorObservable);
  }

  get(url: string, options?: any): Observable<any> {
    options = {...options};
    return this.http.get(this.ROOTPATH + url, options)
      .catch(this.handleErrorObservable)
      .finally(() => {
      });
  }

  handleErrorObservable(error: HttpErrorResponse) {
    console.error(error.error);
    return Observable.throw(error.error);
  }
}
