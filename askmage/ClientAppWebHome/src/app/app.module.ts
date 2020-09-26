import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { LoadingComponent } from './_components/loading/loading.component';
import { COMPONENT } from './_components';
import { ProfileComponent } from './_components/profile/profile.component';
import { ParadoxComponent } from './_components/paradox/paradox.component';
import { ProfileDetailComponent } from './_components/profile-detail/profile-detail.component';
import { AboutComponent } from './_components/about/about.component';
import { AchievementComponent } from './_components/achievement/achievement.component';
import { ContactComponent } from './_components/contact/contact.component';
import { MissionComponent } from './_components/mission/mission.component';
import { TeamComponent } from './_components/team/team.component';
import { ProductComponent } from './_components/product/product.component';
import { RoadMapComponent } from './_components/road-map/road-map.component';
import { AppLayoutComponent } from './_layout';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    ProfileComponent,
    AppLayoutComponent,
    COMPONENT
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      {
        path: '',
        component: AppLayoutComponent,
        //canActivate: [AuthGuard],
        children: [
          { path: '', redirectTo :"/loading" , pathMatch: 'full' },
          { path: 'home', component: HomeComponent },
          { path: 'profile', component: ProfileComponent },
          { path: 'paradox', component: ParadoxComponent },
          { path: 'profiledetail', component: ProfileDetailComponent },
          { path: 'about', component: AboutComponent },
          { path: 'achievement', component: AchievementComponent },
          { path: 'contact', component: ContactComponent },
          { path: 'mission', component: MissionComponent },
          { path: 'team', component: TeamComponent },
          { path: 'product', component: ProductComponent },
          { path: 'roadmap', component: RoadMapComponent },
        ]

      },

      // { path: '', component: HomeComponent, pathMatch: 'full' },
      // { path: 'home', component: HomeComponent },
      // { path: 'profile', component: ProfileComponent },
      // { path: 'paradox', component: ParadoxComponent },
      // { path: 'profiledetail', component: ProfileDetailComponent },
      // { path: 'about', component: AboutComponent },
      // { path: 'achievement', component: AchievementComponent },
      // { path: 'contact', component: ContactComponent },
      // { path: 'mission', component: MissionComponent },
      // { path: 'team', component: TeamComponent },
      // { path: 'product', component: ProductComponent },
      // { path: 'roadmap', component: RoadMapComponent },
      // no layout routes
       { path: 'loading', component: LoadingComponent },
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
