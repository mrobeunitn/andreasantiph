import { NgModule }             from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { PictureViewerComponent}   from './pictureviewer.components';
import { AppComponent }      from './app.component';
import { PictureViewerResolve } from './pictureviewer.resolve.service';
import { ShowAlbumComponent } from './showalbum.component';
import {ErrorComponent} from './error.component'
import { ContactComponent } from './contact.component';

const routes: Routes = [
   { 
    path: '', 
     component: PictureViewerComponent
  },
  {
    path:'album/:id',
    component: ShowAlbumComponent
  },
  {
    path:'notfound',
    component: ErrorComponent
  },
  {
    path:'contacts',
    component: ContactComponent
  },
  {
    path:'**',
    component: ErrorComponent
  }
];
@NgModule({
  imports: [ RouterModule.forRoot(routes) ],
  exports: [ RouterModule ],
  providers: [
    PictureViewerResolve
  ]
})
export class AppRoutingModule {}