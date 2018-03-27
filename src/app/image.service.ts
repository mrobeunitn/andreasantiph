import {Injectable} from '@angular/core';
import { Headers, Http } from '@angular/http';
import {Image} from './image';
import {Album} from './album';
import 'rxjs/add/operator/toPromise';
import { Observable } from 'rxjs';

@Injectable()
export class ImageService{
    
    private baseUrl = 'api/image/';  // URL to web api
    constructor(private http: Http){}
    getIndexImage(): Observable<Image[]> {
        
        return this.http.get(this.baseUrl+'index').map(response => response.json() as Image[]);//.toPromise().then(response => response.json().data as Hero[]).catch(this.handleError);//Promise.resolve(HEROES).then(heroes => heroes.find(hero => hero.id === id));
    }

    private albumbaseUrl = 'api/album/';
    getAlbum():Observable<Album[]>{
        return this.http.get(this.albumbaseUrl+'albums').map(response => response.json() as Album[]);
    }

    getImageByAlbum(id:number):Observable<Image[]>{
        console.log(this.baseUrl+'imagebyalbum?id='+id);
        return this.http.get(this.baseUrl+'imagebyalbum?id='+id).map(response => response.json() as Image[]);
    }


}
