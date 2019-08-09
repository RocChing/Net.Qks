(function () {
    $(function () {
        var _table = $('#UsersTable');
        var _service = abp.services.qks.table;

        var _createOrEditModal = new app.ModalManager({
            viewUrl: abp.appPath + 'Admin/Tables/CreateOrEditModal',
            //scriptUrl: abp.appPath + 'view-resources/Areas/Admin/Views/Users/_CreateOrEditModal.js',
            modalClass: 'CreateOrEditModal'
        });

        var dataTable = _table.DataTable({
            paging: true,
            serverSide: true,
            processing: true,
            listAction: {
                ajaxFunction: _service.getList,
                inputFilter: function () {
                    return {
                        filter: $('#tableFilter').val()
                    };
                }
            },
            columnDefs: [
                {
                    className: 'control responsive',
                    orderable: false,
                    render: function () {
                        return '';
                    },
                    targets: 0
                },
                {
                    targets: 1,
                    data: null,
                    orderable: false,
                    autoWidth: false,
                    defaultContent: '',
                    rowAction: {
                        text: '<i class="fa fa-cog"></i> ' + app.localize('Actions') + ' <span class="caret"></span>',
                        items: [{
                            text: app.localize('LoginAsThisUser'),
                            visible: function (data) {
                                return _permissions.impersonation && data.record.id !== abp.session.userId;
                            },
                            action: function (data) {
                                abp.ajax({
                                    url: abp.appPath + 'Account/Impersonate',
                                    data: JSON.stringify({
                                        tenantId: abp.session.tenantId,
                                        userId: data.record.id
                                    })
                                });
                            }
                        }, {
                            text: app.localize('Edit'),
                            visible: function () {
                                return _permissions.edit;
                            },
                            action: function (data) {
                                _createOrEditModal.open({ id: data.record.id });
                            }
                        }, {
                            text: app.localize('Permissions'),
                            visible: function () {
                                return _permissions.changePermissions;
                            },
                            action: function (data) {
                                _userPermissionsModal.open({ id: data.record.id });
                            }
                        }, {
                            text: app.localize('Unlock'),
                            visible: function () {
                                return _permissions.unlock;
                            },
                            action: function (data) {
                                _userService.unlockUser({
                                    id: data.record.id
                                }).done(function () {
                                    abp.notify.success(app.localize('UnlockedTheUser', data.record.userName));
                                });
                            }
                        }, {
                            text: app.localize('Delete'),
                            visible: function () {
                                return _permissions.delete;
                            },
                            action: function (data) {
                                deleteUser(data.record);
                            }
                        }]
                    }
                },
                {
                    targets: 2,
                    data: "name",
                    render: function (userName, type, row, meta) {
                        var $container = $("<span/>");
                        if (row.profilePictureId) {
                            var profilePictureUrl = "/Profile/GetProfilePictureById?id=" + row.profilePictureId;
                            var $link = $("<a/>").attr("href", profilePictureUrl).attr("target", "_blank");
                            var $img = $("<img/>")
                                .addClass("img-circle")
                                .attr("src", profilePictureUrl);

                            $link.append($img);
                            $container.append($link);
                        }

                        $container.append(userName);
                        return $container[0].outerHTML;
                    }
                },
                {
                    targets: 3,
                    data: "namespace"
                },
                {
                    targets: 4,
                    data: "serviceName"
                },
                {
                    targets: 5,
                    data: "dtoName"
                },
                {
                    targets: 6,
                    data: "authorizeName"
                },
                {
                    targets: 7,
                    data: "getAllInputName"
                },
                {
                    targets: 8,
                    data: "createInputName"
                },
                {
                    targets: 9,
                    data: "creationTime",
                    render: function (creationTime) {
                        return moment(creationTime).format('L');
                    }
                }
            ]
        });

        function getList() {
            dataTable.ajax.reload();
        }

        $('#CreateNewButton').click(function () {
            _createOrEditModal.open();
        });

        $('#tableFilter').on('keydown', function (e) {
            if (e.keyCode !== 13) {
                return;
            }
            e.preventDefault();
            getList();
        });

        abp.event.on('app.createOrEditModalSaved', function () {
            getList();
        });
    });
})();

(function () {
    app.modals.CreateOrEditModal = function () {
        var _service = abp.services.qks.table;

        var _modalManager;
        var _form = null;

        this.init = function (modalManager) {
            _modalManager = modalManager;

            _form = _modalManager.getModal().find('form[name=UserInformationsForm]');
            _form.validate();
        }

        this.save = function () {
            if (!_form.valid()) {
                return;
            }

            var model = _form.serializeFormToObject();

            _modalManager.setBusy(true);
            _service.createOrUpdate(model).done(function () {
                abp.notify.info(app.localize('SavedSuccessfully'));
                _modalManager.close();
                abp.event.trigger('app.createOrEditModalSaved');
            }).always(function () {
                _modalManager.setBusy(false);
            });
        };
    }
})()