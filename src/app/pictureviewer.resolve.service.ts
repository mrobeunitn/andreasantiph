import { Injectable } from '@angular/core';
import {
    Router, Resolve,
    ActivatedRouteSnapshot
} from '@angular/router';
import { Image } from './image';
import { ImageService } from './image.service';
import { Observable } from 'rxjs/Observable';

@Injectable()
export class PictureViewerResolve implements Resolve<any> {
    constructor(private imageservice: ImageService, private router: Router) { }
    
    resolve(route: ActivatedRouteSnapshot): Observable<Image[]> {
        let id = +route.params['id'];
        return this.imageservice.getIndexImage().map(image => {return image});
    }
}