<template>
  <div class="about">
    <h1>This is an about page</h1>
    <a-button type="primary">Primary</a-button>
    <a-button>Default</a-button>
    <a-button type="dashed">Dashed</a-button>
    <a-button type="danger">Danger</a-button>
    <a-config-provider :autoInsertSpaceInButton="false">
      <a-button type="primary">按钮</a-button>
    </a-config-provider>
    <a-button type="primary">按钮</a-button>
  <a-button type="primary"> <a-icon type="user" />Go back </a-button>
  </div>
</template>
